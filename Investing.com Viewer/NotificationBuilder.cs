using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Viewer
{
    public static class NotificationBuilder
    {
        public static async Task<Image> CreateNotificationImageAsync(string base64, string imagePath)
        {
            Image avatar = await AvatarProvider.GetImageAsync(imagePath);

            var bitmapData = Convert.FromBase64String(FixBase64ForImage(base64));
            using (var ms = new MemoryStream(bitmapData))
            {
                var image = Bitmap.FromStream(ms);

                if (avatar != null)
                {
                    using (var graphics = Graphics.FromImage(image))
                    {
                        graphics.DrawImage(avatar, 8, 18);
                    }
                }

                return image;
            }
        }

        private static string FixBase64ForImage(string image)
        {
            var sbText = new StringBuilder(image, image.Length);

            sbText.Replace("data:image/png;base64,", String.Empty);
            sbText.Replace("\r\n", String.Empty);
            sbText.Replace(" ", String.Empty);

            return sbText.ToString();
        }
    }
}
