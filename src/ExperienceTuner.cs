using ExperienceTuner.MCMSettings;
using ExperienceTuner.Helpers;
using System;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using System.Reflection;




namespace ExperienceTuner
{
    public class ExperienceTuner : MBSubModuleBase
    {
        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();
            new ModInit();
        }
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            //TODO
            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarterObject;
                campaignStarter.AddBehavior(new ModBehavior());
            }
        }
    }
    public class ModBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.HourlyTickEvent.AddNonSerializedListener(this, Tick);
        }
        private void Tick() { MessageHelper.DisplayMessage("Poo Poo Pee Pee", TextColor.Red); }
        public override void SyncData(IDataStore dataStore)
        {
            // only used if we need to save stuff...
        }
    }
    public class ModInit
    {
        public static string ModVersion = "";

        public ModInit()
        {
            DisplayModVersion();
        }
        private static void DisplayModVersion()
        {
            ModVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            MessageHelper.DisplayMessage($"Experience Tuner Version: {ModVersion} Successfully loaded!", TextColor.SkyBlue);
        }
    }
}