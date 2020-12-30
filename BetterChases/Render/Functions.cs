using System.Drawing;
using static BetterChases.Render.Classes;
using static BetterChases.Render.Variables;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace BetterChases.Render
{
    public class Functions
    {
                
        public static void ShowSubtitle(string text, int duration = 2500)
        {
            Function.Call(Hash.BEGIN_TEXT_COMMAND_PRINT, "CELL_EMAIL_BCON");
            Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, text);
            Function.Call(Hash.END_TEXT_COMMAND_PRINT, duration, true);
        }

        public static void ShowHelpMessage(string text)
        {
            HelpMessages.Add(text);
        }
    
        public static void ShowBigMessage(string text, string description, HudColor color, HudColor background, int duration = 3000)
        {
            BigMessage message = new BigMessage
            {
                text = text,
                description = description,
                color = color,
                background = background,
                duration = duration
            };
            BigMessages.Add(message);
        }
    }
}