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
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            procedureOwner.SetData<VarString>("NextSceneId", "GameMain");
            ChangeState<ProcedureChangeScene>(procedureOwner);
        }
    }
}
