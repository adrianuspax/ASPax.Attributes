using System;

namespace ASPax.Attributes.Meta
{
    public abstract class EnableIfAttributeBase : MetaAttribute
    {
        private readonly string[] conditions;
        private readonly Utility.EConditionOperator conditionOperator;
        protected bool isInverted;
        public Enum enumValue;

        public EnableIfAttributeBase(string condition)
        {
            conditionOperator = Utility.EConditionOperator.And;
            conditions = new string[1] { condition };
        }

        public EnableIfAttributeBase(Utility.EConditionOperator conditionOperator, params string[] conditions)
        {
            this.conditionOperator = conditionOperator;
            this.conditions = conditions;
        }

        public EnableIfAttributeBase(string enumName, Enum enumValue) : this(enumName)
        {
            this.enumValue = enumValue ?? throw new ArgumentNullException(nameof(enumValue), "This parameter must be an enum value.");
        }
        /// <summary>
        /// If this not null, <see cref="Conditions"/>[0] is name of an enum variable.
        /// </summary>
        public Enum EnumValue => enumValue;
        public string[] Conditions => conditions;
        public Utility.EConditionOperator ConditionOperator => conditionOperator;
        public bool IsInverted => isInverted;
    }
}
