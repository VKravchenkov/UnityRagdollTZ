using RagDoll_TZ.Managers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RagDoll_TZ.UI
{
    public class UIMenuController : MonoBehaviour
    {
        [SerializeField] private Button restartButton;
        [SerializeField] private Button weakBulletButton;
        [SerializeField] private Button mediumBulletButton;
        [SerializeField] private Button strongBulletButton;

        private void Start()
        {
            restartButton.onClick.AddListener(OnClickRestartButton);
            weakBulletButton.onClick.AddListener(OnClickWeakBulletButton);
            mediumBulletButton.onClick.AddListener(OnClickMediumBulletButton);
            strongBulletButton.onClick.AddListener(OnClickStrongBulletButton);

            EventManager.UpdateBulletForce(TypeForce.Medium);
        }

        private void OnClickRestartButton()
        {
            EventManager.RestartZombie();
        }

        private void OnClickWeakBulletButton()
        {
            EventManager.UpdateBulletForce(TypeForce.Weak);
        }

        private void OnClickMediumBulletButton()
        {
            EventManager.UpdateBulletForce(TypeForce.Medium);
        }

        private void OnClickStrongBulletButton()
        {
            EventManager.UpdateBulletForce(TypeForce.Strong);
        }
    }
}
