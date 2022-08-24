using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Obstacle
{
    public abstract class Obstacle : MonoBehaviour
    {
		[Tooltip("Damage applied to Idamageable")]
		[SerializeField] private float m_Damage;

		private void OnCollisionEnter2D(Collision2D collision)
		{
			//if(collision.gameObject.TryGetComponent(out IDamageable damageable)
			if(true)// check for Idamageable
			{
				Obstruct(); // send damageable
			}
		}

		protected virtual void Obstruct()
		{
			// send the damage to damageable
		}
	}
}
