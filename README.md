# RespawnEntity

Custom BuildingEntity that enables players to interact and set their respawn point.

### Setup

1. edit Language.cs and add the following:

```
    public enum UITextKeys : ushort

        // Addon - RespawnEntity
        UI_RESPAWN_BIND_DIALOG,
        UI_RESPAWN_BIND_SUCCESS,
```

```
    public static class DefaultLocale

			// Addon - RespawnEntity
            Texts.Add(UITextKeys.UI_RESPAWN_BIND_DIALOG.ToString(), "Would you like to bind here? If your character dies, you will return to life at the last bind location used.");
            Texts.Add(UITextKeys.UI_RESPAWN_BIND_SUCCESS.ToString(), "You are bound here.");
```

2. create RespawnEntity prefab and add RespawnEntity component
3. add RespawnEntity prefab to Scene and save to buildings table with BuildingEntity Manager
4. ensure MapInfo start position is near default RespawnEntity

### Settings

RespawnEntity settings is found on the GameInstance component:

- ShowRespawnEntityDialog (*true = dialog appears confirming bind, false = immediate bind*)

Optionally replace strings in LanguageManager on GameInstance component:

- UI_RESPAWN_BIND_DIALOG
- UI_RESPAWN_BIND_SUCCESS
