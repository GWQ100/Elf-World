using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace ElfWorld
{
    public class ProcedureCombal : ProcedureBase
    {
        private readonly Dictionary<GameModel, GameBase> m_Games = new Dictionary<GameModel, GameBase>();
        private GameBase m_CurrentGameBase = null;
        
        public override bool UseNativeDialog
        {
            get
            {
                return true;
            }
        }
        
        protected override void OnInit(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            m_Games.Add(GameModel.Combat,new GameCombat());
        }
        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);
            GameModel gameMode = (GameModel)procedureOwner.GetData<VarByte>("GameModel").Value;
            m_CurrentGameBase = m_Games[GameModel.Combat];
            m_CurrentGameBase.Initialize();
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
            
            if (m_CurrentGameBase != null)
            {
                m_CurrentGameBase.OnUpdate(elapseSeconds,realElapseSeconds);
            }
        }

        protected override void OnLeave(ProcedureOwner procedureOwner, bool isShutdown)
        {
            base.OnLeave(procedureOwner, isShutdown);
            if (m_CurrentGameBase != null)
            {
                m_CurrentGameBase.OnShutdown();
            }
        }
    }
}

