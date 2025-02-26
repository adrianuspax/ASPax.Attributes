using System;

namespace ASPax.Attributes.Meta
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class BoxGroupAttribute : MetaAttribute, IGroupAttribute
    {
        private readonly string name;
        private const string EMPTY = "";

        public BoxGroupAttribute(string name = EMPTY)
        {
            this.name = name;
        }

        public string Name => name;
    }
}
