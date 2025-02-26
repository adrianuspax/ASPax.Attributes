using System;

namespace ASPax.Attributes.Validator
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class ValidateInputAttribute : ValidatorAttribute
    {
        private readonly string callbackName;
        private readonly string message;

        public ValidateInputAttribute(string callbackName, string message = null)
        {
            this.callbackName = callbackName;
            this.message = message;
        }

        public string CallbackName => callbackName;
        public string Message => message;
    }
}
