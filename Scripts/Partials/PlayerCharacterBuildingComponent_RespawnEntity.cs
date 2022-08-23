/**
 * PlayerCharacterBuildingComponent_RespawnEntity
 * Author: Denarii Games
 * Version: 1.0
 */

using System;
using System.Collections.Generic;
using LiteNetLibManager;
using UnityEngine;

namespace MultiplayerARPG
{
	public partial class PlayerCharacterBuildingComponent
	{
		public bool CallServerRespawnBind(uint objectId)
		{
			if (!CurrentGameplayRule.CanInteractEntity(Entity, objectId))
			{
				ClientGenericActions.ClientReceiveGameMessage(UITextKeys.UI_ERROR_CHARACTER_IS_TOO_FAR);
				return false;
			}

			RPC(ServerRespawnBind, objectId);
			return true;
		}

		[ServerRpc]
		protected void ServerRespawnBind(uint objectId)
		{
#if !CLIENT_BUILD
			if (!Entity.CanDoActions()) return;

			BuildingEntity buildingEntity;
			if (!Manager.TryGetEntityByObjectId(objectId, out buildingEntity)) return;

			//check distance
			if (!Entity.IsGameEntityInDistance(buildingEntity, CurrentGameInstance.conversationDistance))
			{
				GameInstance.ServerGameMessageHandlers.SendGameMessage(ConnectionId, UITextKeys.UI_ERROR_CHARACTER_IS_TOO_FAR);
				return;
			}

			Entity.RespawnMapName = Entity.RespawnMapName;
			Entity.RespawnPosition = Entity.CurrentPosition;
			GameInstance.ServerGameMessageHandlers.SendGameMessage(ConnectionId, UITextKeys.UI_RESPAWN_BIND_SUCCESS);
#endif
		}

	}
}