using System.Collections;
using UnityEngine;
using System;

namespace Paralysed.Character
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D m_Rigidbody;
        private bool b_HasHit;
        [SerializeField] private float m_AliveTime;

        public Action<Bullet> OnBulletDisable;

        private Coroutine m_DeathRoutine;
        private WaitForSeconds m_DeathWait;

        private void Awake()
        {
            m_DeathWait = new WaitForSeconds(m_AliveTime);
        }

		private void OnEnable()
		{
            m_DeathRoutine = StartCoroutine(DeathTimer());
		}
		private void OnDisable()
		{
            StopCoroutine(m_DeathRoutine);
			OnBulletDisable(this);
		}

		private IEnumerator DeathTimer()
		{
            gameObject.SetActive(true);
            yield return m_DeathWait;
            gameObject.SetActive(false);
		}

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
                
            }

			if (other.gameObject.TryGetComponent(out PlayerController controller))
			{
                Camera.CameraController.Instance.CameraShake(0.2f,2f);
                gameObject.SetActive(false);
                return;
            }
        }
	}
}

