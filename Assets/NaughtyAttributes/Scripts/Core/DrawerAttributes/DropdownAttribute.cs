using System.Collections;
using System;
using System.Collections.Generic;

namespace ASPax.Attributes.Drawer
{
    public interface IDropdownList : IEnumerable<KeyValuePair<string, object>> { }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class DropdownAttribute : DrawerAttribute
    {
        private readonly string valuesName;

        public DropdownAttribute(string valuesName)
        {
            this.valuesName = valuesName;
        }

        public string ValuesName => valuesName;
    }

    public class DropdownList<T> : IDropdownList
    {
        private readonly List<KeyValuePair<string, object>> _values;

        public DropdownList()
        {
            _values = new List<KeyValuePair<string, object>>();
        }

        public void Add(string displayName, T value)
        {
            _values.Add(new KeyValuePair<string, object>(displayName, value));
        }

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static explicit operator DropdownList<object>(DropdownList<T> target)
        {
            DropdownList<object> result = new();

            foreach (var kvp in target)
            {
                result.Add(kvp.Key, kvp.Value);
            }

            return result;
        }
    }
}
