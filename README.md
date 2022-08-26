# RespawnEntity

![RespawnEntity](https://user-images.githubusercontent.com/755461/186205687-87f42538-e331-4e1a-9f00-c6c29ecbcee3.png)

Addon for [MMORPG Kit](https://assetstore.unity.com/packages/templates/systems/mmorpg-kit-2d-3d-survival-110188) provides custom BuildingEntity that enables players to set their respawn point.

Kit respawn is static and set by map or faction. RepawnEntity introduces gameplay common in many MMOs, enabling players to set their own respawn point by interacting with an object.

### Setup

1. **(Core edit)** edit Language.cs and add the following:

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
3. add RespawnEntity prefab to Scene and save to buildings table with [BuildingEntity Manager](https://github.com/denariigames/BuildingEntityManager)
4. ensure MapInfo start position is near default RespawnEntity

### Settings

RespawnEntity settings are found on the GameInstance component:

- ShowRespawnEntityDialog (*true = dialog appears confirming bind, false = immediate bind*)

Optionally replace strings in LanguageManager on GameInstance component:

- UI_RESPAWN_BIND_DIALOG
- UI_RESPAWN_BIND_SUCCESS
