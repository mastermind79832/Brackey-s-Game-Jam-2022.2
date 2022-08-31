using UnityEngine;
using Paralysed.Core;

namespace Paralysed.Obstacle
{
	public abstract class Obstacle : MonoBehaviour
    {
		[Tooltip("Damage applied to Idamageable")]
		[SerializeField] private float m_Damage;

		private void OnCollisionEnter2D(Collision2D collision)
		{
			// if(collision.gameObject.TryGetComponent(out IDamageable damageable)
			if(collision.gameObject.TryGetComponent(out IDamageable damageable)) // check for Idamageable
			{
				Obstruct(damageable); // send damageable
			}

			if(collision.gameObject.TryGetComponent(out IRespawnable respawnable))
			{
				respawnable.Respawn();
			}
		}

		protected virtual void Obstruct(IDamageable damageable)
		{
			damageable.TakeDamage(m_Damage);
		}
	}
}
