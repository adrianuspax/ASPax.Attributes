using System;

namespace ASPax.Attributes.Drawer
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class HorizontalLineAttribute : DrawerAttribute
    {
        public const float DefaultHeight = 2.0f;
        public const Utility.EColor DefaultColor = Utility.EColor.Gray;

        private readonly float height;
        private readonly Utility.EColor color;

        public HorizontalLineAttribute(float height = DefaultHeight, Utility.EColor color = DefaultColor)
        {
            this.height = height;
            this.color = color;
        }

        public float Height => height;
        public Utility.EColor Color => color;
    }
}
