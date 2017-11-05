using System;
using System.Windows.Forms;

namespace Viewer
{
    public class DotsProgressBar
    {
        private const char Dot = '.';
        private readonly Form form;
        private readonly int maxDotsCount;
        private Timer timer;

        public DotsProgressBar(Form form, int maxDotsCount)
        {
            this.form = form;
            this.maxDotsCount = maxDotsCount;
        }

        public void Start()
        {
            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = 300;
                timer.Tick += OnTimerTick;
            }

            timer.Start();
        }

        public void Stop()
        {
            if (timer != null)
            {
                timer.Stop();
                RemoveDots();
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void UpdateProgress()
        {
            form.Invoke((Action)(() =>
            {
                var text = form.Text.Substring(form.Text.Length - maxDotsCount, maxDotsCount);
                if (text.Length < maxDotsCount)
                {
                    form.Text += Dot;
                }
                else if (text.Length == maxDotsCount)
                {
                    if (text[0] != Dot)
                        form.Text += Dot;
                    else
                        form.Text = form.Text.Substring(0, form.Text.Length - maxDotsCount);
                }
            }));
        }

        private void RemoveDots()
        {
            form.Invoke((Action)(() =>
            {
                form.Text = form.Text.TrimEnd(Dot);
            }));
        }
    }
}
