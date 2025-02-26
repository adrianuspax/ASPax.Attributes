using System;
using UnityEngine;

namespace ASPax.Attributes.Drawer
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class AnimatorParamAttribute : DrawerAttribute
    {
        private readonly string animatorName;
        private readonly AnimatorControllerParameterType? animatorParamType;

        public AnimatorParamAttribute(string animatorName)
        {
            this.animatorName = animatorName;
            animatorParamType = null;
        }

        public AnimatorParamAttribute(string animatorName, AnimatorControllerParameterType animatorParamType)
        {
            this.animatorName = animatorName;
            this.animatorParamType = animatorParamType;
        }

        public string AnimatorName => animatorName;
        public AnimatorControllerParameterType? AnimatorParamType => animatorParamType;
    }
}
