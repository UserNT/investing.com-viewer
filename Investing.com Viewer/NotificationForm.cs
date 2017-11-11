using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Viewer
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();

            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height / 2);
        }

        public new void Hide()
        {
            flowLayoutPanel.Controls.Clear();

            UpdateHeightAndLocation();

            base.Hide();
        }

        public void Push(Image notificationImage)
        {
            var pictureBox = new PictureBox();
            pictureBox.Margin = pictureBox.Padding = new Padding(0);
            pictureBox.Image = notificationImage;
            pictureBox.Width = notificationImage.Width;
            pictureBox.Height = notificationImage.Height;

            pictureBox.Click += OnPictureBoxClick;
            pictureBox.DoubleClick += OnPictureBoxDoubleClick;

            flowLayoutPanel.Controls.Add(pictureBox);

            UpdateHeightAndLocation();

            pictureBox.Invalidate();
        }

        private void OnPictureBoxClick(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;

            if (flowLayoutPanel.Controls.Count == 1)
            {
                Hide();
                return;
            }

            flowLayoutPanel.Controls.Remove(pictureBox);

            UpdateHeightAndLocation();
        }

        private void OnPictureBoxDoubleClick(object sender, EventArgs e)
        {
            Hide();
        }

        private void UpdateHeightAndLocation()
        {
            if (flowLayoutPanel.Controls.Count > 0)
            {
                Width = flowLayoutPanel.Controls.Cast<Control>().Max(x => x.Width);
                Height = flowLayoutPanel.Controls.Cast<Control>().Sum(x => x.Height);

                flowLayoutPanel.Width = Width;
                flowLayoutPanel.Height = Height;
            }
            else
            {
                flowLayoutPanel.Width = Width = 0;
                flowLayoutPanel.Height = Height = 0;
            }

            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height - 50);
        }
    }
}
