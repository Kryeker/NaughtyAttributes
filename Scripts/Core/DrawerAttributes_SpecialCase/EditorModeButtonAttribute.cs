using System;

namespace NaughtyAttributes
{
    public class EditorModeButtonAttribute : ButtonAttribute
    {
        public EditorModeButtonAttribute(string text = null) : base(text, EButtonEnableMode.Editor)
        {

        }
    }
}
