/**
 * BasePlayerCharacterController_RespawnEntity
 * Author: Denarii Games
 * Version: 1.0
 */

using UnityEngine;

namespace MultiplayerARPG
{
	public abstract partial class BasePlayerCharacterController
	{
		[DevExtMethods("Awake")]
		protected void BasePlayerCharacterController_RespawnEntity_Awake()
		{
			onActivateBuilding += OnActivateRepawnEntity;
		}

		[DevExtMethods("OnDestroy")]
		protected void BasePlayerCharacterController_RespawnEntity_OnDestroy()
		{
			onActivateBuilding -= OnActivateRepawnEntity;
		}

		protected void OnActivateRepawnEntity(BuildingEntity buildingEntity)
		{
			if (buildingEntity is RespawnEntity)
			{
				uint objectId = buildingEntity.ObjectId;

				if (GameInstance.Singleton.ShowRespawnEntityDialog)
					UISceneGlobal.Singleton.ShowMessageDialog(
						buildingEntity.EntityTitle,
						LanguageManager.GetText(UITextKeys.UI_RESPAWN_BIND_DIALOG.ToString()),
						false,
						true,
						true,
						false,
						null,
						() => { OnRespawnBindConfirmed(objectId); }
					);
				else
					PlayerCharacterEntity.Building.CallServerRespawnBind(objectId);

				DeselectBuilding();
			}
		}

		private void OnRespawnBindConfirmed(uint objectId)
		{
			if (objectId == null) return;
			PlayerCharacterEntity.Building.CallServerRespawnBind(objectId);
		}
	}
}