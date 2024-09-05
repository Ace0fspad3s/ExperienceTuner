using System;
using TaleWorlds.Library;


namespace ExperienceTuner.Helpers
{
    public class MessageHelper
    {
        //Text Only
        public static void DisplayMessage(string text) 
        {
            InformationManager.DisplayMessage(new InformationMessage(text));
        }

        //Color Overload
        public static void DisplayMessage(string text, TextColor txtColor)
        {
            Color color = Colors.White;
            switch (txtColor)
            {
                case TextColor.Blue:
                    color = Colors.Blue;
                    break;
                case TextColor.SkyBlue:
                    color = Color.ConvertStringToColor("#0099FFFF");
                    break;
                case TextColor.Cyan:
                    color = Color.ConvertStringToColor("#00FFFFFF");
                    break;
                case TextColor.Green:
                    color = Colors.Green;
                    break;
                case TextColor.Red:
                    color = Colors.Red;
                    break;
                case TextColor.Orange:
                    color = Color.ConvertStringToColor("#FF6F00FF");
                    break;
                case TextColor.White:
                    color = Colors.White;
                    break;
            }

            InformationManager.DisplayMessage(new InformationMessage(text, color));
        }
    }
    public enum TextColor
    {
        Blue,
        SkyBlue,
        Cyan,
        Green,
        Red,
        Orange,
        White
    }
}
