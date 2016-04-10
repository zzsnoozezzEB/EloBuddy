using System;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using SharpDX;

namespace CameraFocus
{
    class Program
    {
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += GameLoaded;
        }

        private static void GameLoaded(EventArgs args)
        {
            Game.OnTick += OnGameTick;
 
        }

        private static void OnGameTick(EventArgs args) {
            Vector2 diff;
            var diffX = Player.Instance.Position.To2D().X - Camera.CameraX;
            for (var i = 0; i < (int)diffX*100; i++)
            {                
                   Camera.CameraX = Camera.CameraX + diffX/100;
            }


        }

    }
}
