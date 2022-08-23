/**
 * GameInstance_RespawnEntity
 * Author: Denarii Games
 * Version: 1.0
 */

using UnityEngine;

namespace MultiplayerARPG
{

	public partial class GameInstance
	{
		[Header("≡ RespawnEntity Settings")]
		[SerializeField] private bool showRespawnEntityDialog = true;

		public bool ShowRespawnEntityDialog
		{
			get { return showRespawnEntityDialog; }
			private set { showRespawnEntityDialog = value; }
		}
	}
}
