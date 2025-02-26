using System;

namespace ASPax.Attributes.Drawer.SpecialCases
{
    public enum EButtonEnableMode
    {
        /// <summary>
        /// Button should be active always
        /// </summary>
        Always,
        /// <summary>
        /// Button should be active only in editor
        /// </summary>
        Editor,
        /// <summary>
        /// Button should be active only in playmode
        /// </summary>
        Playmode
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class ButtonAttribute : SpecialCaseDrawerAttribute
    {
        private readonly string text;
        private readonly EButtonEnableMode selectedEnableMode;

        public ButtonAttribute(string text = null, EButtonEnableMode enabledMode = EButtonEnableMode.Always)
        {
            this.text = text;
            selectedEnableMode = enabledMode;
        }

        public string Text => text;
        public EButtonEnableMode SelectedEnableMode => selectedEnableMode;
    }
}
