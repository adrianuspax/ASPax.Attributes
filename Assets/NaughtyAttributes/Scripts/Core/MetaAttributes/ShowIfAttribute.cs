using System;

namespace ASPax.Attributes.Meta
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class ShowIfAttribute : ShowIfAttributeBase
    {
        public ShowIfAttribute(string condition) : base(condition)
        {
            isInverted = false;
        }

        public ShowIfAttribute(Utility.EConditionOperator conditionOperator, params string[] conditions) : base(conditionOperator, conditions)
        {
            isInverted = false;
        }

        public ShowIfAttribute(string enumName, object enumValue) : base(enumName, enumValue as Enum)
        {
            isInverted = false;
        }
    }
}
