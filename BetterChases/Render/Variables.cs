using System.Collections.Generic;
using CitizenFX.Core.UI;
using NativeUI;
using Font = CitizenFX.Core.UI.Font;
using Color = System.Drawing.Color;
using SizeF = System.Drawing.SizeF;
using PointF = System.Drawing.PointF;
using Sprite = CitizenFX.Core.UI.Sprite;

namespace BetterChases.Render
{
    public class Variables
    {
        public static List<string> HelpMessages = new List<string>();
        public static List<Classes.BigMessage> BigMessages = new List<Classes.BigMessage>();
        public static List<Classes.UIMarker> Markers = new List<Classes.UIMarker>();

        public static int HelpMessageTime = 0;
        public static int HelpMessageInterval = 5000;

        public static int BigMessageTime = 0;
        public static int BigMessageInterval = 5000;

        public static int BetterChasesIconOffsetX;
        public static int BetterChasesIconOffsetY;
        public static int ArrestWarrantsIconOffsetX;
        public static int ArrestWarrantsIconOffsetY;
        public static int ArrestWarrantsTextOffsetX;
        public static int ArrestWarrantsTextOffsetY;
        public static int ArrestWarrantsGradientOffsetX;
        public static int ArrestWarrantsGradientOffsetY;

        public static int ShowBetterChasesHUDUntil = 0;
        public static int ShowArrestWarrantsHUDUntil = 0;
        public static int OffsetChangeDisplayLength = 5000;
        
        public static readonly Sprite CopsRamSprite = new Sprite("mpinventory", "vehicle_deathmatch", new SizeF(18, 18), new PointF(Screen.Width - 265, 5));
        public static readonly Sprite CopsShootSprite = new Sprite("mpinventory", "survival", new SizeF(18, 18), new PointF(Screen.Width - 280, 5));

        public static readonly Sprite PedWantedSprite = new Sprite("mpinventory", "mp_specitem_ped", new SizeF(16, 16), new PointF(Screen.Width - 130, Screen.Height - 19));
        public static readonly Sprite CarWantedSprite = new Sprite("mpinventory", "mp_specitem_car", new SizeF(16, 16), new PointF(Screen.Width - 144, Screen.Height - 19));
        public static readonly Sprite PlaneWantedSprite = new Sprite("mpinventory", "mp_specitem_plane", new SizeF(16, 16), new PointF(Screen.Width - 144, Screen.Height - 19));
        public static readonly Sprite HeliWantedSprite = new Sprite("mpinventory", "mp_specitem_heli", new SizeF(16, 16), new PointF(Screen.Width - 144, Screen.Height - 19));
        public static readonly Sprite BoatWantedSprite = new Sprite("mpinventory", "mp_specitem_boat", new SizeF(16, 16), new PointF(Screen.Width - 144, Screen.Height - 19));
        public static readonly Sprite BikeWantedSprite = new Sprite("mpinventory", "mp_specitem_bike", new SizeF(16, 16), new PointF(Screen.Width - 144, Screen.Height - 19));
            
        
        /* //todo WHAT THE FUCK
        public static readonly Sprite WantedGradient = new Sprite("timerbars", "all_white_bg", new SizeF(500, 22), new PointF(Screen.Width - 490, Screen.Height - 22), Color.DarkRed); 
        public static readonly Sprite MichaelGradient = new Sprite("timerbars", "all_white_bg", new SizeF(500, 22), new PointF(Screen.Width - 490, Screen.Height - 22), Color.CornflowerBlue);
        public static readonly Sprite FranklinGradient = new Sprite("timerbars", "all_white_bg", new SizeF(500, 22), new PointF(Screen.Width - 490, Screen.Height - 22), Color.ForestGreen);
        public static readonly Sprite TrevorGradient = new Sprite("timerbars", "all_white_bg", new SizeF(500, 22), new PointF(Screen.Width - 490, Screen.Height - 22), Color.DarkOrange);
        public static readonly Sprite DimGradient = new Sprite("timerbars", "all_white_bg", new SizeF(500, 22), new PointF(Screen.Width - 490, Screen.Height - 22), Color.DimGray);
        
        public static readonly Container SpottedMeterBG = new Container(new PointF(Screen.Width - 145, Screen.Height - 55), new SizeF(112, 30), Color.FromArgb(220, Color.Black));

        public static Text SuspectWanted = new Text("~w~SUSPECT WANTED", new PointF(Screen.Width - 150, Screen.Height - 20), 0.4f, Color.White, Font.ChaletLondon);
        public static Text WarrantActive = new Text("~w~WARRANT ACTIVE", new PointF(Screen.Width - 150, Screen.Height - 20), 0.4f, Color.White, Font.ChaletLondon);
        public static Text SpottedMeterText = new Text("", new PointF(Screen.Width - 90, Screen.Height - 55), 0.3f, Color.White, Font.ChaletLondon, Alignment.Center);
         */
        
        public static readonly Sprite WantedGradient = new Sprite("timerbars", "all_white_bg", new SizeF(500, 22), new PointF(Screen.Width - 490, Screen.Height - 22), Colors.DarkRed); 
        public static readonly Sprite MichaelGradient = new Sprite("timerbars", "all_white_bg", new SizeF(500, 22), new PointF(Screen.Width - 490, Screen.Height - 22), Colors.CornflowerBlue);
        public static readonly Sprite FranklinGradient = new Sprite("timerbars", "all_white_bg", new SizeF(500, 22), new PointF(Screen.Width - 490, Screen.Height - 22), Colors.ForestGreen);
        public static readonly Sprite TrevorGradient = new Sprite("timerbars", "all_white_bg", new SizeF(500, 22), new PointF(Screen.Width - 490, Screen.Height - 22), Colors.DarkOrange);
        public static readonly Sprite DimGradient = new Sprite("timerbars", "all_white_bg", new SizeF(500, 22), new PointF(Screen.Width - 490, Screen.Height - 22), Colors.DimGray);
        
        public static readonly Container SpottedMeterBG = new Container(new PointF(Screen.Width - 145, Screen.Height - 55), new SizeF(112, 30), Color.FromArgb(220, Colors.Black));

        public static Text SuspectWanted = new Text("~w~SUSPECT WANTED", new PointF(Screen.Width - 150, Screen.Height - 20), 0.4f, Colors.White, Font.ChaletLondon);
        public static Text WarrantActive = new Text("~w~WARRANT ACTIVE", new PointF(Screen.Width - 150, Screen.Height - 20), 0.4f, Colors.White, Font.ChaletLondon);
        public static Text SpottedMeterText = new Text("", new PointF(Screen.Width - 90, Screen.Height - 55), 0.3f, Colors.White, Font.ChaletLondon, Alignment.Center);

    }
}