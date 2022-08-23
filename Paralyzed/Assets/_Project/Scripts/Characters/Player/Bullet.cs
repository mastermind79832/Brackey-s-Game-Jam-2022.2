using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Character
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D m_Rigidbody;
        private bool b_HasHit;

        void Update()
        {
            HasHit();
        }

        private void HasHit()
        {
            if (b_HasHit == false)
            {
                float angle = Mathf.Atan2(m_Rigidbody.velocity.x, m_Rigidbody.velocity.y) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
        }
        public void AddVelocity(Vector2 force)
		{
            m_Rigidbody.velocity += force;
		}

        private void OnCollisionEnter2D(Collision2D other)
        {
            BulletEffect(other);
        }

        private void BulletEffect(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ground") )
            {
                b_HasHit = true;
                m_Rigidbody.velocity = Vector2.zero;
                m_Rigidbody.isKinematic = true;
            }

			if (other.gameObject.TryGetComponent(out PlayerController controller))
			{
                Camera.CameraController.Instance.CameraShake(0.2f,2f);
            }
            Destroy(gameObject);
        }
    }
}

