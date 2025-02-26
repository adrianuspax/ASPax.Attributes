using System;

namespace ASPax.Attributes.Validator
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class MaxValueAttribute : ValidatorAttribute
    {
        private readonly float maxValue;

        public MaxValueAttribute(float maxValue)
        {
            this.maxValue = maxValue;
        }

        public MaxValueAttribute(int maxValue)
        {
            this.maxValue = maxValue;
        }

        public float MaxValue => maxValue;
    }
}
