using System;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;
using Viewer.Properties;

namespace Viewer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            addressTextBox.Text = Settings.Default.HomePage;
            filterIdsTextBox.Text = Join(Settings.Default.FilterIds);
            filterIdsStartsWithTextBox.Text = Join(Settings.Default.FilterIdsStartsWith);
            filterClassesTextBox.Text = Join(Settings.Default.FilterClasses);
            filterMessagesTextBox.Text = Join(Settings.Default.FilterMessages);
            
            if (Settings.Default.IsFilterMessagesInverseMode)
            {
                filterMessagesInverseModeRadioButton.Checked = true;
            }
            else
            {
                filterMessagesRadioButton.Checked = true;
            }

            showNotificationsCheckBox.Checked = Settings.Default.ShowNotifications;
        }

        private static string Join(StringCollection collection)
        {
            if (collection == null)
            {
                return string.Empty;
            }

            return string.Join(Environment.NewLine, collection.Cast<string>());
        }

        private static StringCollection Split(string text)
        {
            var collection = new StringCollection();

            if (!string.IsNullOrWhiteSpace(text))
            {
                collection.AddRange(text.Split(new[] { Environment.NewLine }, StringSplitOptions.None));
            }

            return collection;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.HomePage = addressTextBox.Text;
            Settings.Default.FilterIds = Split(filterIdsTextBox.Text);
            Settings.Default.FilterIdsStartsWith = Split(filterIdsStartsWithTextBox.Text);
            Settings.Default.FilterClasses = Split(filterClassesTextBox.Text);
            Settings.Default.FilterMessages = Split(filterMessagesTextBox.Text);
            Settings.Default.IsFilterMessagesInverseMode = filterMessagesInverseModeRadioButton.Checked;
            Settings.Default.ShowNotifications = showNotificationsCheckBox.Checked;

            Settings.Default.Save();
        }
    }
}
