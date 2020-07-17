using RagDoll_TZ.Data;
using RagDoll_TZ.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RagDoll_TZ.Controllers
{
    public class HitController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.tag == Tags.Bullet.ToString())
            {
                Time.timeScale = 0.3f;

                BulletController bulletController = collision.collider.GetComponent<BulletController>();

                gameObject.GetComponent<Rigidbody>()
                          .AddForce(bulletController.DirectionForce * Bullets.CurrentBulletForce.ScaleForce, ForceMode.Impulse);


                EventManager.HitEnemy();

            }
        }
    }
}
