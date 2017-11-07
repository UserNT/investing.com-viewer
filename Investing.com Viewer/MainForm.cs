using CefSharp;
using CefSharp.WinForms;
using Viewer.Properties;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Viewer
{
    public partial class MainForm : Form, IKeyboardHandler
    {
        private readonly DotsProgressBar progressBar;
        private readonly ChromiumWebBrowser browser;
        private ToolStrip toolStrip;
        private ToolStripButton backButton;
        private ToolStripButton forwardButton;

        //public static string GetDefaultExeConfigPath(ConfigurationUserLevel userLevel)
        //{
        //    try
        //    {
        //        var UserConfig = ConfigurationManager.OpenExeConfiguration(userLevel);
        //        return UserConfig.FilePath;
        //    }
        //    catch (ConfigurationException e)
        //    {
        //        return e.Filename;
        //    }
        //}

        public MainForm()
        {
            InitializeComponent();

            //var path0 = GetDefaultExeConfigPath(ConfigurationUserLevel.PerUserRoaming);
            //var path1 = GetDefaultExeConfigPath(ConfigurationUserLevel.PerUserRoamingAndLocal);

            progressBar = new DotsProgressBar(this, 5);
            
            filterContentToolStripMenuItem.CheckState = BooleanToCheckState(Settings.Default.IsFilterContent);
            filterMessagesToolStripMenuItem.CheckState = BooleanToCheckState(Settings.Default.IsFilterMessages);
            showLogToolStripMenuItem.CheckState = BooleanToCheckState(Settings.Default.IsLogVisible);

            try
            {
                if (!Cef.IsInitialized)
                {
                    var settings = new CefSettings()
                    {
                        //By default CefSharp will use an in-memory cache, you need to specify a Cache Folder to persist data
                        CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache")
                    };

                    //Perform dependency check to make sure all relevant resources are in our output directory.
                    Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
                }

                browser = new ChromiumWebBrowser(Properties.Settings.Default.HomePage)
                {
                    Dock = DockStyle.Fill
                };

                BuildToolStrip();
                addressToolStripMenuItem.CheckState = BooleanToCheckState(Settings.Default.IsAddressVisible);

                browser.LoadingStateChanged += Browser_LoadingStateChanged;
                browser.ConsoleMessage += Browser_ConsoleMessage;
                browser.KeyboardHandler = this;
                this.Controls.Add(browser);
                browser.BringToFront();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            progressBar.Stop();
        }

        private static CheckState BooleanToCheckState(bool value)
        {
            return value ? CheckState.Checked : CheckState.Unchecked;
        }

        private void RemoveBanners()
        {
            try
            {
                var script = GetScript();

                if (!string.IsNullOrWhiteSpace(script))
                {
                    browser.ExecuteScriptAsync(script);
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void Browser_ConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            if (e.Message == "trace" || e.Message == "info")
            {
                return;
            }

            Log(e.Message);
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            UpdateNavigationButtons(e);

            Log(e.Browser.MainFrame.Url);

            if (!e.IsLoading)
            {
                RemoveBanners();
                progressBar.Stop();
            }
            else
            {
                progressBar.Start();
            }
        }

        private void UpdateNavigationButtons(LoadingStateChangedEventArgs e)
        {
            Invoke((Action)(() =>
            {
                goBackToolStripMenuItem.Enabled = backButton.Enabled = e.CanGoBack;
                goForwardToolStripMenuItem.Enabled = forwardButton.Enabled = e.CanGoForward;
                refreshToolStripMenuItem.Enabled = e.CanReload;
            }));
        }

        private string GetScript()
        {
            var script = new StringBuilder();

            if (Settings.Default.IsFilterContent)
            {
                if (Settings.Default.FilterIds.Count > 0)
                {
                    script.AppendLine("function AIRemoveElementById(id) {");
                    script.AppendLine("     $('#' + id).remove();");
                    script.AppendLine("}");

                    for (int i = 0; i < Settings.Default.FilterIds.Count; i++)
                    {
                        script.AppendLine("AIRemoveElementById('" + Settings.Default.FilterIds[i] + "');");
                    }
                }

                if (Settings.Default.FilterIdsStartsWith.Count > 0)
                {
                    script.AppendLine("function AIRemoveElementByIdStartWith(idStartWith) {");
                    script.AppendLine("     $('[id^=\"' + idStartWith + '\"]').remove();");
                    script.AppendLine("}");

                    for (int i = 0; i < Settings.Default.FilterIdsStartsWith.Count; i++)
                    {
                        script.AppendLine("AIRemoveElementByIdStartWith('" + Settings.Default.FilterIdsStartsWith[i] + "');");
                    }
                }

                if (Settings.Default.FilterClasses.Count > 0)
                {
                    script.AppendLine("function AIRemoveElementByClass(c) {");
                    script.AppendLine("     $('.' + c).remove();");
                    script.AppendLine("}");

                    for (int i = 0; i < Settings.Default.FilterClasses.Count; i++)
                    {
                        script.AppendLine("AIRemoveElementByClass('" + Settings.Default.FilterClasses[i] + "');");
                    }
                }
            }

            if (Settings.Default.IsFilterMessages && Settings.Default.FilterMessages.Count > 0)
            {
                string returnWhenInList = Settings.Default.IsFilterMessagesInverseMode ? "false" : "true";
                string returnWhenNotInList = Settings.Default.IsFilterMessagesInverseMode ? "true" : "false";

                script.AppendLine("function AIShouldHide(memberPath) {");
                script.AppendLine("     if (memberPath) {");
                for (int i = 0; i < Settings.Default.FilterMessages.Count; i++)
                {
                    script.AppendLine("         if (memberPath == '" + Settings.Default.FilterMessages[i] + "') return " + returnWhenInList + ";");
                }

                script.AppendLine("         return " + returnWhenNotInList + ";");
                script.AppendLine("     }");
                script.AppendLine("     else {");
                script.AppendLine("         return true;");
                script.AppendLine("     }");
                script.AppendLine("}");

                script.AppendLine("function AIHideCommentIfNeeded(jdiv) {");
                script.AppendLine("     var memberPath = jdiv.find('[href^=\"/members/\"]').attr('href');");
                script.AppendLine("     if (AIShouldHide(memberPath)) {");
                script.AppendLine("         jdiv.hide();");
                script.AppendLine("     }");
                if (Settings.Default.IsFilterMessagesInverseMode)
                {
                    script.AppendLine("     else {");
                    script.AppendLine("         jdiv.parent().show();");
                    script.AppendLine("     }");
                }
                script.AppendLine("};");

                script.AppendLine("$(document).bind('DOMNodeInserted', function(e) {");
                script.AppendLine("     var jelement = $(e.target);");
                script.AppendLine("     var id = jelement.attr('id');");
                script.AppendLine("     if (id && id.lastIndexOf('comment-', 0) === 0) {");
                script.AppendLine("         AIHideCommentIfNeeded(jelement);");
                script.AppendLine("     }");
                script.AppendLine("});");

                script.AppendLine("$('[id^=\"comment-\"]').each(function(index, comment) {");
                script.AppendLine("     AIHideCommentIfNeeded($(comment));");
                script.AppendLine("});");
            }

            return script.ToString();
        }

        #region IKeyboardHandler

        public bool OnPreKeyEvent(IWebBrowser browserControl, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey, ref bool isKeyboardShortcut)
        {
            return false;
        }

        public bool OnKeyEvent(IWebBrowser browserControl, IBrowser browser, KeyType type, int windowsKeyCode, int nativeKeyCode, CefEventFlags modifiers, bool isSystemKey)
        {
            if (windowsKeyCode == (int)Keys.F5)
            {
                ReloadWebPage();

                return true;
            }
            return false;
        }

        private void ReloadWebPage()
        {
            if (browser != null)
            {
                Invoke((Action)(() =>
                {
                    browser.Reload();
                }));
            }
        }

        #endregion

        #region Navigation menu handlers

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            if (browser.GetBrowser().CanGoBack)
            {
                browser.Back();
            }
        }

        private void goForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoForward();
        }

        private void GoForward()
        {
            if (browser.GetBrowser().CanGoForward)
            {
                browser.Forward();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadWebPage();
        }

        #endregion

        #region Filters menu handlers

        private void filterContentToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            var newState = (filterContentToolStripMenuItem.CheckState == CheckState.Checked);

            SetFilterContent(newState);
        }

        private void SetFilterContent(bool newState)
        {
            if (Settings.Default.IsFilterContent != newState)
            {
                Settings.Default.IsFilterContent = newState;
                Settings.Default.Save();
            }

            ReloadWebPage();
        }

        private void filterMessagesToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            var newState = (filterMessagesToolStripMenuItem.CheckState == CheckState.Checked);

            SetFilterMessages(newState);
        }

        private void SetFilterMessages(bool newState)
        {
            if (Settings.Default.IsFilterMessages != newState)
            {
                Settings.Default.IsFilterMessages = newState;
                Settings.Default.Save();
            }

            ReloadWebPage();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var settings = new SettingsForm())
            {
                settings.ShowDialog(this);

                ReloadWebPage();
            }
        }

        #endregion

        #region View menu handlers

        private void showLogToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            var newState = (showLogToolStripMenuItem.CheckState == CheckState.Checked);

            SetLogVisibility(newState);
        }

        private void SetLogVisibility(bool newState)
        {
            if (Settings.Default.IsLogVisible != newState)
            {
                Settings.Default.IsLogVisible = newState;
                Settings.Default.Save();
            }

            consoleTextBox.Visible = Settings.Default.IsLogVisible;
        }

        public void Log(string message)
        {
            Invoke((Action)(() =>
            {
                message = DateTime.Now.ToLongTimeString() + ": " + message + Environment.NewLine;

                consoleTextBox.Text = consoleTextBox.Text.Insert(0, message);
            }));
        }

        private void addressToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            var newState = (addressToolStripMenuItem.CheckState == CheckState.Checked);

            SetAdressVisibility(newState);
        }

        private void SetAdressVisibility(bool newState)
        {
            if (Settings.Default.IsAddressVisible != newState)
            {
                Settings.Default.IsAddressVisible = newState;
                Settings.Default.Save();
            }

            if (Settings.Default.IsAddressVisible)
            {
                Controls.Add(toolStrip);
                toolStrip.BringToFront();
                browser.BringToFront();
            }
            else
            {
                Controls.Remove(toolStrip);
            }
        }

        private void BuildToolStrip()
        {
            backButton = new ToolStripButton("<") { ToolTipText = "Back" };
            backButton.Click += BackButton_Click;

            forwardButton = new ToolStripButton(">") { ToolTipText = "Forward" };
            forwardButton.Click += ForwardButton_Click;

            toolStrip = new ToolStrip();
            toolStrip.Dock = DockStyle.Top;
            toolStrip.Items.Add(backButton);
            toolStrip.Items.Add(forwardButton);
            toolStrip.Items.Add(new AddressTextBox(this, browser));
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            GoForward();
        }

        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var about = new AboutForm())
            {
                about.ShowDialog(this);
            }
        }
    }
}
