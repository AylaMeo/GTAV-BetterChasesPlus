using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;
using NativeUI;
using static BetterChases.Render.Classes;
using static BetterChases.Render.Variables;
using static BetterChases.Render.Functions;
using Font = CitizenFX.Core.UI.Font;

namespace BetterChases.Render
{
    public class Core : BaseScript
    {
        private Scaleform Scaleform = new Scaleform("MP_BIG_MESSAGE_FREEMODE");

        public Core()
        {
            Tick += OnTick;

            //Interval = 4; todo this

            Function.Call(Hash.REQUEST_STREAMED_TEXTURE_DICT, "WEB_LOSSANTOSPOLICEDEPT", true);
        }

        private async Task OnTick()
        {
            //await Delay(4); //todo this
            
            //System.Diagnostics.Stopwatch Stopwatch = System.Diagnostics.Stopwatch.StartNew();
            //Stopwatch.Start();

            if (Function.Call<bool>(Hash.IS_HUD_HIDDEN) || Function.Call<bool>(Hash.IS_PLAYER_SWITCH_IN_PROGRESS))
                return;

            Ped Character = Game.Player.Character;
            int WantedLevel = Game.Player.WantedLevel;
            
            // Option Offsets
            if ((Config.Options.BetterChases.IconOffsetX != 0 && Config.Options.BetterChases.IconOffsetX != BetterChasesIconOffsetX) || (Config.Options.BetterChases.IconOffsetY != 0 && Config.Options.BetterChases.IconOffsetY != BetterChasesIconOffsetY))
            {
                CopsRamSprite.Position = new PointF(Screen.Width - 265 + Config.Options.BetterChases.IconOffsetX, 5 + Config.Options.BetterChases.IconOffsetY);
                CopsShootSprite.Position = new PointF(Screen.Width - 280 + Config.Options.BetterChases.IconOffsetX, 5 + Config.Options.BetterChases.IconOffsetY);
                
                ShowBetterChasesHUDUntil = Game.GameTime;
                BetterChasesIconOffsetX = Config.Options.BetterChases.IconOffsetX;
                BetterChasesIconOffsetY = Config.Options.BetterChases.IconOffsetY;
            }
            else if ((Config.Options.ArrestWarrants.IconOffsetX != 0 && Config.Options.ArrestWarrants.IconOffsetX != ArrestWarrantsIconOffsetX) || (Config.Options.ArrestWarrants.IconOffsetY != 0 && Config.Options.ArrestWarrants.IconOffsetY != ArrestWarrantsIconOffsetY))
            {
                PedWantedSprite.Position = new PointF(Screen.Width - 130 + Config.Options.ArrestWarrants.IconOffsetX, Screen.Height - 19 + Config.Options.ArrestWarrants.IconOffsetY);
                CarWantedSprite.Position = new PointF(Screen.Width - 144 + Config.Options.ArrestWarrants.IconOffsetX, Screen.Height - 19 + Config.Options.ArrestWarrants.IconOffsetY);
                PlaneWantedSprite.Position = new PointF(Screen.Width - 144 + Config.Options.ArrestWarrants.IconOffsetX, Screen.Height - 19 + Config.Options.ArrestWarrants.IconOffsetY);
                HeliWantedSprite.Position = new PointF(Screen.Width - 144 + Config.Options.ArrestWarrants.IconOffsetX, Screen.Height - 19 + Config.Options.ArrestWarrants.IconOffsetY);
                BoatWantedSprite.Position = new PointF(Screen.Width - 144 + Config.Options.ArrestWarrants.IconOffsetX, Screen.Height - 19 + Config.Options.ArrestWarrants.IconOffsetY);
                BikeWantedSprite.Position = new PointF(Screen.Width - 144 + Config.Options.ArrestWarrants.IconOffsetX, Screen.Height - 19 + Config.Options.ArrestWarrants.IconOffsetY);

                ShowArrestWarrantsHUDUntil = Game.GameTime;
                ArrestWarrantsIconOffsetX = Config.Options.ArrestWarrants.IconOffsetX;
                ArrestWarrantsIconOffsetY = Config.Options.ArrestWarrants.IconOffsetY;
            }
            else if ((Config.Options.ArrestWarrants.TextOffsetX != 0 && Config.Options.ArrestWarrants.TextOffsetX != ArrestWarrantsTextOffsetX) || (Config.Options.ArrestWarrants.TextOffsetY != 0 && Config.Options.ArrestWarrants.TextOffsetY != ArrestWarrantsTextOffsetY))
            {
                SuspectWanted = new Text("~w~SUSPECT WANTED", new PointF(Screen.Width - 150 + Config.Options.ArrestWarrants.TextOffsetX, Screen.Height - 20 + Config.Options.ArrestWarrants.TextOffsetY), 0.4f, Colors.White, Font.ChaletLondon);
                WarrantActive = new Text("~w~WARRANT ACTIVE", new PointF(Screen.Width - 150 + Config.Options.ArrestWarrants.TextOffsetX, Screen.Height - 20 + Config.Options.ArrestWarrants.TextOffsetY), 0.4f, Colors.White, Font.ChaletLondon);
                
                ShowArrestWarrantsHUDUntil = Game.GameTime;
                ArrestWarrantsTextOffsetX = Config.Options.ArrestWarrants.TextOffsetX;
                ArrestWarrantsTextOffsetY = Config.Options.ArrestWarrants.TextOffsetY;
            }
            else if ((Config.Options.ArrestWarrants.GradientOffsetX != 0 && Config.Options.ArrestWarrants.GradientOffsetX != ArrestWarrantsGradientOffsetX) || (Config.Options.ArrestWarrants.GradientOffsetY != 0 && Config.Options.ArrestWarrants.GradientOffsetY != ArrestWarrantsGradientOffsetY))
            {
                WantedGradient.Position = new PointF(Screen.Width - 490 + Config.Options.ArrestWarrants.GradientOffsetX, Screen.Height - 22 + Config.Options.ArrestWarrants.GradientOffsetY);
                MichaelGradient.Position = new PointF(Screen.Width - 490 + Config.Options.ArrestWarrants.GradientOffsetX, Screen.Height - 22 + Config.Options.ArrestWarrants.GradientOffsetY);
                FranklinGradient.Position = new PointF(Screen.Width - 490 + Config.Options.ArrestWarrants.GradientOffsetX, Screen.Height - 22 + Config.Options.ArrestWarrants.GradientOffsetY);
                TrevorGradient.Position = new PointF(Screen.Width - 490 + Config.Options.ArrestWarrants.GradientOffsetX, Screen.Height - 22 + Config.Options.ArrestWarrants.GradientOffsetY);
                DimGradient.Position = new PointF(Screen.Width - 490 + Config.Options.ArrestWarrants.GradientOffsetX, Screen.Height - 22 + Config.Options.ArrestWarrants.GradientOffsetY);

                ShowArrestWarrantsHUDUntil = Game.GameTime;
                ArrestWarrantsGradientOffsetX = Config.Options.ArrestWarrants.GradientOffsetX;
                ArrestWarrantsGradientOffsetY = Config.Options.ArrestWarrants.GradientOffsetY;
            }
            
            if (Config.IsMenuOpen && ShowBetterChasesHUDUntil != 0 && ShowBetterChasesHUDUntil + OffsetChangeDisplayLength > Game.GameTime)
            {
                CopsRamSprite.Draw();
                CopsShootSprite.Draw();
            }
            else if (Config.IsMenuOpen && ShowArrestWarrantsHUDUntil != 0 && ShowArrestWarrantsHUDUntil + OffsetChangeDisplayLength > Game.GameTime)
            {
                WantedGradient.Draw();
                PedWantedSprite.Draw();
                CarWantedSprite.Draw();
                SuspectWanted.Draw();
            }
            else
            {
                if (Config.Options.BetterChases.ShowHUD && BetterChases.ActiveChase.PITAuthorized && WantedLevel > 0)
                {
                    CopsRamSprite.Draw();
                }

                if (Config.Options.BetterChases.ShowHUD && BetterChases.ActiveChase.DeadlyForce && WantedLevel > 0)
                {
                    CopsShootSprite.Draw();
                }
                
                if (Config.Options.ArrestWarrants.ShowHUD && (ArrestWarrants.PedWarrant.pedHash != 0 || (ArrestWarrants.VehicleWarrant.vehicleHash != 0 && Helpers.IsValid(Character.CurrentVehicle) && Character.CurrentVehicle.Model.Hash == ArrestWarrants.VehicleWarrant.vehicleHash)))
                {
                    if (WantedLevel > 0 || Function.Call<bool>(Hash.ARE_PLAYER_STARS_GREYED_OUT, Game.Player))
                    {
                        SuspectWanted.Draw();
                        WantedGradient.Draw();
                    }
                    else
                    {
                        WarrantActive.Draw();

                        if (Character.Model == PedHash.Michael)
                        {
                            MichaelGradient.Draw();
                        }
                        else if (Character.Model == PedHash.Franklin)
                        {
                            FranklinGradient.Draw();
                        }
                        else if (Character.Model == PedHash.Trevor)
                        {
                            TrevorGradient.Draw();
                        }
                        else
                        {
                            DimGradient.Draw();
                        }
                    }

                    if (ArrestWarrants.PedWarrant.pedHash != 0)
                    {
                        PedWantedSprite.Draw();
                    }

                    if (ArrestWarrants.VehicleWarrant.vehicleHash != 0 && Helpers.IsValid(Character.CurrentVehicle) && Character.CurrentVehicle.Model.Hash == ArrestWarrants.VehicleWarrant.vehicleHash)
                    {
                        if (Helpers.GetModel(ArrestWarrants.VehicleWarrant.vehicleHash).IsCar)
                        {
                            CarWantedSprite.Draw();
                        }
                        else if (Helpers.GetModel(ArrestWarrants.VehicleWarrant.vehicleHash).IsBicycle || Helpers.GetModel(ArrestWarrants.VehicleWarrant.vehicleHash).IsBike)
                        {
                            BikeWantedSprite.Draw();
                        }
                        else if (Helpers.GetModel(ArrestWarrants.VehicleWarrant.vehicleHash).IsBoat)
                        {
                            BoatWantedSprite.Draw();
                        }
                        else if (Helpers.GetModel(ArrestWarrants.VehicleWarrant.vehicleHash).IsPlane)
                        {
                            PlaneWantedSprite.Draw();
                        }
                        else if (Helpers.GetModel(ArrestWarrants.VehicleWarrant.vehicleHash).IsHelicopter)
                        {
                            HeliWantedSprite.Draw();
                        }
                    }
                }
            }
            
            // Recognition Markers
            if (Config.Options.ArrestWarrants.ShowSpottedIndicators && Markers.Count > 0)
            {
                foreach (Classes.UIMarker marker in Markers)
                {
                    World.DrawMarker(marker.Type, marker.Entity.Position + new Vector3(0f, 0f, 1.5f), new Vector3(0, 0, 0), new Vector3(0f, 180f, 0f), new Vector3(0.5f, 0.5f, 0.5f), marker.Color, true, false, true, "", "", false);
                }
            }
            
            // Recognition meter
            if (Config.Options.ArrestWarrants.ShowSpottedMeter && Markers.Count > 0 && ArrestWarrants.ShowSpottedMeter)
            {
                SpottedMeterBG.Draw();
                SpottedMeterText.Caption = "A cop is watching you.~n~~y~Recognition process: ~r~" + Math.Round(ArrestWarrants.SpottedMeter, 0) + "%";
                SpottedMeterText.Draw();
            }

            // Display Help Messages
            if (HelpMessages.Count > 0 && Game.GameTime > HelpMessageTime + HelpMessageInterval)
            {
                Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_HELP, "STRING");
                Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, HelpMessages[0]);
                Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_HELP, 0, 0, 0, HelpMessageInterval);

                HelpMessageTime = Game.GameTime;
                HelpMessages.RemoveAt(0);
            }

            // Display Big Messages
            if (BigMessages.Count > 0 && BigMessageTime == 0 && Game.GameTime > BigMessageTime + BigMessageInterval)
            {
                Classes.BigMessage message = BigMessages[0];
                Scaleform.CallFunction("SHOW_SHARD_CENTERED_MP_MESSAGE", message.text, message.description, (int)message.color, (int)message.background);
                Function.Call(Hash.PLAY_SOUND_FRONTEND, 0, "CHECKPOINT_NORMAL", "HUD_MINI_GAME_SOUNDSET");

                BigMessageTime = Game.GameTime;
                BigMessageInterval = message.duration;
            }
            else if (BigMessageTime > 0 && Game.GameTime < BigMessageTime + BigMessageInterval)
            {
                Scaleform.Render2D();
            }
            else if (BigMessageTime > 0 && Game.GameTime > BigMessageTime + BigMessageInterval)
            {
                Scaleform.CallFunction("TRANSITION_OUT");
                BigMessageTime = 0;
                BigMessages.RemoveAt(0);
            }

            //Stopwatch.Stop();
            //UI.ShowSubtitle("Debug: " + "" + " CPU: " + Stopwatch.Elapsed);
        }
    }
}