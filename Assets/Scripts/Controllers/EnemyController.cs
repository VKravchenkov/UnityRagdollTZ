using RagDoll_TZ.Managers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RagDoll_TZ.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private Animator animatorEnemy;
        [SerializeField] private List<Rigidbody> rigidbodies;

        private void Start()
        {
            rigidbodies = new List<Rigidbody>();
            rigidbodies = gameObject.GetComponentsInChildren<Rigidbody>().ToList();

            OnActivateRagdoll(false);

        }

        private void OnEnable()
        {
            EventManager.OnHitEnemy += () => OnActivateRagdoll();
            EventManager.OnRestartZombie += () => OnActivateRagdoll(false);
        }

        private void OnDisable()
        {
            EventManager.OnHitEnemy -= () => OnActivateRagdoll();
            EventManager.OnRestartZombie -= () => OnActivateRagdoll(false);
        }

        private void OnActivateRagdoll(bool isActivate = true)
        {
            foreach (Rigidbody item in rigidbodies)
            {
                item.isKinematic = !isActivate;
            }

            animatorEnemy.enabled = !isActivate;

            if (isActivate == false)
            {
                Time.timeScale = 1f;
            }
        }
    }
}
