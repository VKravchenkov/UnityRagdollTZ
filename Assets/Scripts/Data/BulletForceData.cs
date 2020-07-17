using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RagDoll_TZ.Data
{
    [CreateAssetMenu(fileName = "New BulletForceData", menuName = "BulletForceData", order = 51)]
    public class BulletForceData : ScriptableObject
    {
        #region Fields
        [SerializeField] private TypeForce typeForce;
        [SerializeField] private float scaleForce;
        #endregion

        #region Properties
        public float ScaleForce => scaleForce;
        public TypeForce TypeForce => typeForce;
        #endregion
    }
}
