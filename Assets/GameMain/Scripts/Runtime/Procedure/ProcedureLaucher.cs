using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace ElfWorld
{
    public class ProcedureLaucher : ProcedureBase
    {
        public override bool UseNativeDialog
        {
            get
            {
                return true;
            }
        }
        
        private bool m_InitResourcesComplete = false;
        
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            GameEntry.Resource.InitResources(OnInitResourcesComplete);
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            if(!m_InitResourcesComplete) return;
            
            procedureOwner.SetData<VarString>("NextSceneId", "GameMain");
            ChangeState<ProcedureChangeScene>(procedureOwner);
        }

        private void OnInitResourcesComplete()
        {
            m_InitResourcesComplete = true;
            Log.Debug("Init Resouces Complete");
        }
    }
}
