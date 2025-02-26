using UnityEngine;
using UnityEditor;

namespace ASPax.Editor
{
    using ASPax.Attributes.Utility;

    [CustomPropertyDrawer(typeof(Attributes.Drawer.HorizontalLineAttribute))]
    public class HorizontalLineDecoratorDrawer : DecoratorDrawer
    {
        public override float GetHeight()
        {
            var lineAttr = (Attributes.Drawer.HorizontalLineAttribute)attribute;
            return EditorGUIUtility.singleLineHeight + lineAttr.Height;
        }

        public override void OnGUI(Rect position)
        {
            var rect = EditorGUI.IndentedRect(position);
            rect.y += EditorGUIUtility.singleLineHeight / 3.0f;
            var lineAttr = (Attributes.Drawer.HorizontalLineAttribute)attribute;
            NaughtyEditorGUI.HorizontalLine(rect, lineAttr.Height, lineAttr.Color.GetColor());
        }
    }
}
