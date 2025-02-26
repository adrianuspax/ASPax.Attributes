using System.Collections.Generic;
using UnityEngine;

namespace ASPax.Test
{
    using ASPax.Attributes.Drawer;

    //[CreateAssetMenu(fileName = "NaughtyScriptableObject", menuName = "NaughtyAttributes/_NaughtyScriptableObject")]
    public class _NaughtyScriptableObject : ScriptableObject
    {
        [Expandable]
        public List<_TestScriptableObjectA> listA;
    }
}
