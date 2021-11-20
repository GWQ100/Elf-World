using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ElfWorld
{
    public class MainForm : UGuiForm
    {

        [SerializeField]
        private Button m_StartButton;

        private ProcedureMain m_ProcedureMain = null;

        private void OnStartButtonClick()
        {
            m_ProcedureMain.StartGame();
        }


        protected override void OnOpen(object userData)
        {
            base.OnOpen(userData);
            m_ProcedureMain = userData as ProcedureMain;
            m_StartButton.onClick.AddListener(OnStartButtonClick);
        }

        protected override void OnClose(bool isShutdown, object userData)
        {
            base.OnClose(isShutdown,userData);
        }
    }
}

