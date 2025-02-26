using System;
using UnityEngine;

namespace ASPax.Attributes.Drawer
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class CurveRangeAttribute : DrawerAttribute
    {
        private Vector2 min;
        private Vector2 max;
        private readonly Utility.EColor color;

        public CurveRangeAttribute(Vector2 min, Vector2 max, Utility.EColor color = Utility.EColor.Clear)
        {
            this.min = min;
            this.max = max;
            this.color = color;
        }

        public CurveRangeAttribute(Utility.EColor color) : this(Vector2.zero, Vector2.one, color) { }

        public CurveRangeAttribute(float minX, float minY, float maxX, float maxY, Utility.EColor color = Utility.EColor.Clear) : this(new Vector2(minX, minY), new Vector2(maxX, maxY), color) { }

        public Vector2 Min => min;
        public Vector2 Max => max;
        public Utility.EColor Color => color;
    }
}
