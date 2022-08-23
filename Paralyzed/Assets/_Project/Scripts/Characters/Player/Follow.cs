using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Character
{
    public class Follow : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float m_Speed = 2.0f;

        private float interpolation;

        void LateUpdate()
        {
            interpolation = m_Speed * Time.deltaTime;
            GunFollowTheReference(interpolation);
        }
        private void GunFollowTheReference(float interpolation)
        {
            Vector3 position = transform.position;
            position.y = Mathf.Lerp(transform.position.y, target.position.y, interpolation);
            position.x = Mathf.Lerp(transform.position.x, target.position.x, interpolation);

            transform.position = position;
        }
    }
}