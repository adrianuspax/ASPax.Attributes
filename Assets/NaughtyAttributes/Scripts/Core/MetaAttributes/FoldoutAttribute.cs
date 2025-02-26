using System;

namespace ASPax.Attributes.Meta
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class FoldoutAttribute : MetaAttribute, IGroupAttribute
    {
        private readonly string name;

        public FoldoutAttribute(string name)
        {
            this.name = name;
        }

        public string Name => name;
    }
}
