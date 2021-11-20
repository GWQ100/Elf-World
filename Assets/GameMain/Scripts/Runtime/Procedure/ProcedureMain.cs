using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace ElfWorld
{
    public class ProcedureMain : ProcedureBase
    {

        private bool m_StartGame = false;

        private int m_MainFormId = 0;

        public override bool UseNativeDialog
        {
            get
            {
                return true;
            }
        }

        public void StartGame()
        {
            m_StartGame = true;
        }

        protected override void OnInit(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
        }
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            m_MainFormId = GameEntry.UI.OpenUIForm(AssetUtility.GetUIFormAsset("MainForm"),"Default",this);
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            if(m_StartGame)
            {
                procedureOwner.SetData<VarString>("NextSceneId","GameCombat");
                procedureOwner.SetData<VarByte>("GameModel",(byte)GameModel.Combat);
                ChangeState<ProcedureChangeScene>(procedureOwner);
            }
        }

        protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
            GameEntry.UI.CloseUIForm(m_MainFormId);
        }

    }
}

