using RagDoll_TZ.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RagDoll_TZ.Controllers
{
    public class ShootingController : MonoBehaviour
    {
        [SerializeField] private BulletController bulletPrefab;
        [SerializeField] private Transform transformPositionSpawn;
        [SerializeField] private Camera cameraThis;

        private void FixedUpdate()
        {

            Ray mouseRey = cameraThis.ScreenPointToRay(Input.mousePosition);

            RaycastHit raycastHit;

            if (Physics.Raycast(cameraThis.transform.position, mouseRey.direction, out raycastHit))
            {
                Debug.DrawRay(cameraThis.transform.position, mouseRey.direction * raycastHit.distance, Color.green);
                Debug.DrawLine(raycastHit.point, transformPositionSpawn.position, Color.blue);
            }
            else
            {
                Debug.DrawRay(cameraThis.transform.position, mouseRey.direction * 10, Color.red);
            }

            if (Input.GetMouseButtonDown(0))
            {

                if (raycastHit.collider != null)
                {
                    Vector3 directionNew = raycastHit.point - transformPositionSpawn.position;

                    BulletController instanceBullet = Instantiate(bulletPrefab, transformPositionSpawn.position, Quaternion.identity);

                    //instanceBullet.name = $"Bullet ->{Bullets.CurrentBulletForce.name}";

                    instanceBullet.SetDirectionForce(directionNew);

                    instanceBullet.GetComponent<Rigidbody>().AddForce(directionNew * 0.5f, ForceMode.Impulse);
                }
            }
        }
    }
}
