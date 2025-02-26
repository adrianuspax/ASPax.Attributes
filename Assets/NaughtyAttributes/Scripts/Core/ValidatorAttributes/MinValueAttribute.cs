using System;

namespace ASPax.Attributes.Validator
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class MinValueAttribute : ValidatorAttribute
    {
        private readonly float minValue;

        public MinValueAttribute(float minValue)
        {
            this.minValue = minValue;
        }

        public MinValueAttribute(int minValue)
        {
            this.minValue = minValue;
        }

        public float MinValue => minValue;
    }
}
