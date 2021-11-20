using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ElfWorld
{
    public class GameCombat : GameBase
    {
        public override GameModel GameModel
        {
            get { return GameModel.Combat; }
        }

        public override void Initialize()
        {
            base.Initialize();
            GameEntry.Entity.ShowEntity<Pet>(0,AssetUtility.GetEntityAsset("Pet"),"Default");
        }

        public override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
        }

        public override void OnShutdown()
        {
            base.OnShutdown();
        }
    }
}