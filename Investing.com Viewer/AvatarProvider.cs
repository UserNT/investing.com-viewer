using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;

namespace Viewer
{
    /// <summary>
    /// I need this image loader, just because canvas.toDataURL('image/png') fails with error:
    /// SecurityError: Failed to execute 'toDataURL' on 'HTMLCanvasElement': Tainted canvases may not be exported.
    /// </summary>
    public static class AvatarProvider
    {
        private static readonly ConcurrentDictionary<string, Image> avatars = new ConcurrentDictionary<string, Image>();

        public static async Task<Image> GetImageAsync(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                return null;
            }

            Image avatar;
            if (avatars.TryGetValue(imagePath, out avatar))
            {
                return avatar;
            }

            Uri imageUri;
            if (!Uri.TryCreate(imagePath, UriKind.Absolute, out imageUri))
            {
                return null;
            }

            using (var client = new HttpClient())
            {
                using (var avatarStream = await client.GetStreamAsync(imageUri))
                {
                    avatar = Bitmap.FromStream(avatarStream);

                    if (avatar != null && avatar.Width != 33 && avatar.Height != 33)
                    {
                        avatar = new Bitmap(avatar, new Size(33, 33));
                    }
                }
            }

            if (avatar != null)
            {
                avatars.TryAdd(imagePath, avatar);
            }

            return avatar;
        }
    }
}
