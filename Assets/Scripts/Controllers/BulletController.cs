using RagDoll_TZ.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RagDoll_TZ.Controllers
{
    public class BulletController : MonoBehaviour
    {
        [SerializeField] private float timeLife;
        [SerializeField] private Vector3 directionForce;

        public Vector3 DirectionForce => directionForce;

        private void Awake()
        {
            if (!CompareTag(Tags.Bullet.ToString()))
                gameObject.tag = Tags.Bullet.ToString();
        }

        private void FixedUpdate()
        {
            timeLife -= Time.fixedDeltaTime;

            if (timeLife <= 0)
                Destroy(gameObject);
        }

        public void SetDirectionForce(Vector3 value)
        {
            directionForce = value;
        }
    }
}
