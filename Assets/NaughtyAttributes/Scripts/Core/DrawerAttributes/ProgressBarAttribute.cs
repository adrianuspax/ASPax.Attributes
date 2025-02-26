using System;

namespace ASPax.Attributes.Drawer
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class ProgressBarAttribute : DrawerAttribute
    {
        private readonly string name;
        private readonly float maxValue;
        private readonly string maxValueName;
        private readonly Utility.EColor color;

        public ProgressBarAttribute(string name, float maxValue, Utility.EColor color = Utility.EColor.Blue)
        {
            this.name = name;
            this.maxValue = maxValue;
            this.color = color;
        }

        public ProgressBarAttribute(string name, string maxValueName, Utility.EColor color = Utility.EColor.Blue)
        {
            this.name = name;
            this.maxValueName = maxValueName;
            this.color = color;
        }

        public ProgressBarAttribute(float maxValue, Utility.EColor color = Utility.EColor.Blue) : this(string.Empty, maxValue, color) { }

        public ProgressBarAttribute(string maxValueName, Utility.EColor color = Utility.EColor.Blue) : this(string.Empty, maxValueName, color) { }

        public string Name => name;
        public float MaxValue =>  maxValue;
        public string MaxValueName => maxValueName;
        public Utility.EColor Color => color;
    }
}
