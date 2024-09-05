# ExperienceTuner

## Description
Written in C#, heavily utilizing C#'s [extension methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods).
This is a W.I.P mod for the game [Mount & Blade 2: Bannerlord](https://www.taleworlds.com/en/Games/Bannerlord)
Based on [KaosesTweaks](https://github.com/KaosesBanerlord/KaosesTweaks)

This is my first attempt at modding the game!

This mod aims to be a simple & lightweight option for players to configure XP values in the game.
This was developed out of a need to have a mod that is easily maintainable for future patches, thus focusing on only a few features.


## Dependencies
* [Mount & Blade 2: Bannerlord](https://www.taleworlds.com/en/Games/Bannerlord)
* BUTR (Harmony for Bannerlord) [Repo Link](https://github.com/BUTR/Bannerlord.Harmony)
* Bannerlord MCM [Repo Link](https://github.com/Aragas/Bannerlord.MBOptionScreen)
* NET 4.8

### NOTE: 
VS Solution build script references a $(BANNERLORD_GAME_DIR) environment variable that must be set to your game folder!!
ex: \SteamLibrary\steamapps\common\Mount & Blade II Bannerlord

Huge thank you to the BUTR team for providing their resources. A large chunk of my time was spent setting up my VS environment.
This was helped greatly by modifying their template [here](https://github.com/BUTR/Bannerlord.Module.Template).


### TODO
* XP functions have not yet been enabled in the mod. 
* At this time the mod only prints a test message in game during the campaign ticks.