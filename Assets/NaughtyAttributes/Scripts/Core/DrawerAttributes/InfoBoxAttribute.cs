using System;

namespace ASPax.Attributes.Drawer
{
    public enum EInfoBoxType
    {
        Normal,
        Warning,
        Error
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class InfoBoxAttribute : DrawerAttribute
    {
        private readonly string text;
        private readonly EInfoBoxType type;

        public InfoBoxAttribute(string text, EInfoBoxType type = EInfoBoxType.Normal)
        {
            this.text = text;
            this.type = type;
        }

        public string Text => text;
        public EInfoBoxType Type => type;
    }
}
