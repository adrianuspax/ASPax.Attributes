using System;

namespace ASPax.Attributes.Meta
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class OnValueChangedAttribute : MetaAttribute
    {
        private readonly string callbackName;

        public OnValueChangedAttribute(string callbackName)
        {
            this.callbackName = callbackName;
        }

        public string CallbackName => callbackName;
    }
}
