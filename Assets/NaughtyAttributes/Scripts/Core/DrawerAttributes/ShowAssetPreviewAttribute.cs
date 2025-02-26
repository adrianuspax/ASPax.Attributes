using System;

namespace ASPax.Attributes.Drawer
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class ShowAssetPreviewAttribute : DrawerAttribute
    {
        public const int DefaultWidth = 64;
        public const int DefaultHeight = 64;

        private readonly int width;
        private readonly int height;

        public ShowAssetPreviewAttribute(int width = DefaultWidth, int height = DefaultHeight)
        {
            this.width = width;
            this.height = height;
        }

        public int Width => width;
        public int Height => height;
    }
}
