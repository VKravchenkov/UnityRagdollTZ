using RagDoll_TZ.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RagDoll_TZ.Data
{
    public class Bullets : Singleton<Bullets>
    {
        [SerializeField] private List<BulletForceData> bulletForceDatas;
        [SerializeField] private BulletForceData currentBulletForce;

        public static BulletForceData CurrentBulletForce => Instance.currentBulletForce;

        private void OnEnable()
        {
            EventManager.OnBulletForce += SelectBulletForce;
        }

        private void OnDisable()
        {
            EventManager.OnBulletForce -= SelectBulletForce;
        }

        private void SelectBulletForce(TypeForce typeForce)
        {
            currentBulletForce = bulletForceDatas.Find(item => item.TypeForce == typeForce);
        }
    }
}
