/**
 * RespawnEntity
 * Author: Denarii Games
 * Version: 1.0
 *
 * Add component to RespawnEntity prefab.
 */

using UnityEngine;

namespace MultiplayerARPG
{
	public partial class RespawnEntity : BuildingEntity
	{
		public override bool Activatable { get { return true; } }

		public override void OnSetup()
		{
			base.OnSetup();
		}

		protected override void SetupNetElements()
		{
			base.SetupNetElements();
		}

		protected override void EntityOnDestroy()
		{
			base.EntityOnDestroy();
		}
	}
}
