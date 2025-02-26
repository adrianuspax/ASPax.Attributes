using System;

namespace ASPax.Attributes.Drawer
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class MinMaxSliderAttribute : DrawerAttribute
    {
        private readonly float minValue;
        private readonly float maxValue;

        public MinMaxSliderAttribute(float minValue, float maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public (float min, float max) Value => (minValue, maxValue);
    }
}
