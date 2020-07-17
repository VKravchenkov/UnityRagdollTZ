using RagDoll_TZ.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RagDoll_TZ.Managers
{
    public static class EventManager
    {
        public static event Action OnRestartZombie;

        public static event Action OnHitEnemy;

        public static event Action<TypeForce> OnBulletForce;

        public static void RestartZombie()
        {
            OnRestartZombie?.Invoke();
        }


        public static void HitEnemy()
        {
            OnHitEnemy?.Invoke();
        }

        public static void UpdateBulletForce(TypeForce typeForce)
        {
            OnBulletForce?.Invoke(typeForce);
        }
    }
}
