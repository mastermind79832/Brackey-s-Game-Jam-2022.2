using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Paralysed.Core;

namespace Paralysed.Character
{
    public class PlayerController : MonoBehaviour, IDamageable, IRespawnable
	{ 
		[Header("Componenet")]
        [SerializeField] private Rigidbody2D m_Rigidbody;
		[SerializeField] private BatteryController m_BatteryController;

		[Header("Ground Check")]
        [SerializeField] private float m_CheckRadius;
        [SerializeField] private Transform m_GroundCheck;
        private bool b_IsGrounded;

		[Header("Jump Properties")]
        [SerializeField] private float m_JumpForce;
        [SerializeField] private float m_JumpTime;
        private float m_JumpTimeCounter;
        private bool b_IsJumping;

		[Header("Ground Collider layer")]
        [SerializeField] private LayerMask m_WhatIsGround;

		private Vector3 m_RespawnPoint;

		private void Start()
		{
			m_RespawnPoint = transform.position;
		}

		private void Update()
        {
            GetInput();
        }

        private void GetInput()
		{
			CheckGround();

			if (Input.GetMouseButtonDown(1) && b_IsGrounded)
			{
				b_IsJumping = true;
				m_JumpTimeCounter = m_JumpTime;
				Jump();
			}
			if (Input.GetMouseButton(1) && b_IsJumping)
			{
				if (m_JumpTimeCounter > 0)
				{
					Jump();
					DecreaseJumpTimer();
				}
				else
					b_IsJumping = false;
			}
			if (Input.GetMouseButtonUp(1) && !b_IsGrounded)
			{
				b_IsJumping = false;
			}
		}

		private void DecreaseJumpTimer() =>	m_JumpTimeCounter -= Time.deltaTime;
		private void Jump() => m_Rigidbody.velocity = Vector2.up * m_JumpForce;
		private void CheckGround() => b_IsGrounded = Physics2D.OverlapCircle(m_GroundCheck.position, m_CheckRadius, m_WhatIsGround);

		public void TakeDamage(float value)
		{
			m_BatteryController.Reduce(value);
		}

		public void SetRespawn(Vector3 respawnPoint)
		{
			m_RespawnPoint = respawnPoint;
		}

		public void Respawn()
		{
			transform.position = m_RespawnPoint;
		}
	}
}
