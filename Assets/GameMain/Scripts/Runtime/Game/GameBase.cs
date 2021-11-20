using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ElfWorld
{
    public abstract class GameBase
    {
        public abstract GameModel GameModel { get; }

        public bool GameOver { get; protected set; }

        public virtual void Initialize()
        {

        }

        public virtual void OnUpdate(float elapseSeconds, float realElapseSeconds)
        {

        }

        public virtual void OnShutdown()
        {

        }

    }
}
