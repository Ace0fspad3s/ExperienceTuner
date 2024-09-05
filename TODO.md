TODO:
6.18.2024 - SEE MCMSettings.cs

Most likely called via CampaignEvents.TickEvent.AddNonSerializedListener
see example:

```C#
public override void RegisterEvents()
{
    ...
    CampaignEvents.TickEvent.AddNonSerializedListener(this, new Action<float>(this.Tick));
}

private void Tick(float f)
{
    InformationManager.DisplayMessage(new InformationMessage("Tick"));
}
```


Build scripts (NEED TO UPDATE FROM OLD PROJECT):

XCOPY /y /h /c /i "$(MSBuildProjectDirectory)\Build\x64\Release\net472\*.dll" "$(ProjectDir)\_Module\$(MSBuildProjectName)\"

XCOPY "$Env:Bannerlord_Project_DIR\XP Adjuster for Bannerlord\Build\x64\Release\net472\*.dll" "$Env:Bannerlord_Project_DIR\XP Adjuster for Bannerlord\_Module"