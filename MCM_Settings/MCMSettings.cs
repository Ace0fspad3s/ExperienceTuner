using ExperienceTuner.Helpers;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;
using System;


namespace ExperienceTuner.MCMSettings
{
    public class MCMSettings : AttributeGlobalSettings<MCMSettings>
    {

        //TODO - Don't think I can call testMessages  at runtime, but I just need a quick way to test the MCM Button thing..
        [SettingPropertyGroup("Aces Hello World Test"),
        SettingPropertyBool("TestButton", IsToggle = true, Order = 0, RequireRestart = false,
            HintText = "Toggle on to spam test messages!")]

        public bool testMessages { get; set; } = false;

        //MCM Tab Display Options
        public override string Id { get { return base.GetType().Assembly.GetName().Name; } }
        public override string DisplayName { get { return base.GetType().Assembly.GetName().Name; } }
        public override string FolderName { get { return base.GetType().Assembly.GetName().Name; } }

        


    }
}
