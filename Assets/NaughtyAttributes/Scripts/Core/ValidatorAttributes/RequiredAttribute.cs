using System;

namespace ASPax.Attributes.Validator
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class RequiredAttribute : ValidatorAttribute
    {
        private readonly string message;

        public RequiredAttribute(string message = null)
        {
            this.message = message;
        }

        public string Message => message;
    }
}
