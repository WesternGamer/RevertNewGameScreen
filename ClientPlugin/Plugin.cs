using Sandbox.Game;
using System;
using VRage.Plugins;

namespace ClientPlugin
{
    // ReSharper disable once UnusedType.Global
    public class Plugin : IPlugin, IDisposable
    {
        public void Init(object gameInstance)
        {
            MyPlatformGameSettings.USE_SCENARIOSELECTION_NEWGAME_SCREEN = false;
        }

        public void Dispose()
        {
           
        }

        public void Update()
        {
            
        }
    }
}