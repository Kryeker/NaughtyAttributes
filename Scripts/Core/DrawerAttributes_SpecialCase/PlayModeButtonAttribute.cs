using System;

namespace NaughtyAttributes
{
    public class PlayModeButtonAttribute : ButtonAttribute
    {
        public PlayModeButtonAttribute(string text = null) : base(text, EButtonEnableMode.Playmode)
        {

        }
    }
}
