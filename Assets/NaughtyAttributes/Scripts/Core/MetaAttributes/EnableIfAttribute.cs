using System;

namespace ASPax.Attributes.Meta
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class EnableIfAttribute : EnableIfAttributeBase
    {
        public EnableIfAttribute(string condition) : base(condition)
        {
            isInverted = false;
        }

        public EnableIfAttribute(Utility.EConditionOperator conditionOperator, params string[] conditions) : base(conditionOperator, conditions)
        {
            isInverted = false;
        }

        public EnableIfAttribute(string enumName, object enumValue) : base(enumName, enumValue as Enum)
        {
            isInverted = false;
        }
    }
}
