using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;


namespace ElfWorld
{
    public class Pet : EntityLogic
    {

        private PetData m_PetData;
        
        protected override void OnInit(object userData)
        {
            base.OnInit(userData);
            // m_PetData = userData as PetData;
            
            
        }
        protected override void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(elapseSeconds, realElapseSeconds);
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward,Space.Self);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back,Space.Self);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.back,Space.Self);
            }
        }
    }
}