using System;

namespace ASPax.Attributes.Meta
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class LabelAttribute : MetaAttribute
    {
        private readonly string label;

        public LabelAttribute(string label)
        {
            this.label = label;
        }

        public string Label => label;
    }
}
