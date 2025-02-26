using UnityEditor;
using UnityEngine;

namespace ASPax.Editor
{
    [CustomPropertyDrawer(typeof(Attributes.Drawer.InfoBoxAttribute))]
    public class InfoBoxDecoratorDrawer : DecoratorDrawer
    {
        public override float GetHeight()
        {
            return GetHelpBoxHeight();
        }

        public override void OnGUI(Rect rect)
        {
            var infoBoxAttribute = (Attributes.Drawer.InfoBoxAttribute)attribute;
            var indentLength = NaughtyEditorGUI.GetIndentLength(rect);
            var infoBoxRect = new Rect()
            {
                x = rect.x + indentLength,
                y = rect.y,
                width = rect.width - indentLength,
                height = GetHelpBoxHeight()
            };
                

            DrawInfoBox(infoBoxRect, infoBoxAttribute.Text, infoBoxAttribute.Type);
        }

        private float GetHelpBoxHeight()
        {
            var infoBoxAttribute = (Attributes.Drawer.InfoBoxAttribute)attribute;
            var minHeight = EditorGUIUtility.singleLineHeight * 2.0f;
            var desiredHeight = GUI.skin.box.CalcHeight(new GUIContent(infoBoxAttribute.Text), EditorGUIUtility.currentViewWidth);
            var height = Mathf.Max(minHeight, desiredHeight);

            return height;
        }

        private void DrawInfoBox(Rect rect, string infoText, Attributes.Drawer.EInfoBoxType infoBoxType)
        {
            var messageType = MessageType.None;
            switch (infoBoxType)
            {
                case Attributes.Drawer.EInfoBoxType.Normal:
                    messageType = MessageType.Info;
                    break;

                case Attributes.Drawer.EInfoBoxType.Warning:
                    messageType = MessageType.Warning;
                    break;

                case Attributes.Drawer.EInfoBoxType.Error:
                    messageType = MessageType.Error;
                    break;
            }

            NaughtyEditorGUI.HelpBox(rect, infoText, messageType);
        }
    }
}
