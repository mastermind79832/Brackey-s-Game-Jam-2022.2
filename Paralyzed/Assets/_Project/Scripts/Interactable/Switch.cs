using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Paralysed.Core;
using System;

namespace Paralysed.Interactable
{
	public class Switch : Interactable
	{
		[Header("Component References")]
		[SerializeField] private Animator m_Animator;

		[Header("Switch Properties")]
		[Tooltip("Initially should the swtich be on")]
		[SerializeField] private bool b_InitialState;
		private ISwitchConnectable connection;
		[Tooltip("Keep this false if you want to switch to be interact only once")]
		[SerializeField] private bool b_IsMultiActivateable;
		[SerializeField] private bool b_IsActive;
		// to store if the switch has already been activated once
		private bool b_IsActivatedOnce;

		private readonly int anim_IsActive = Animator.StringToHash("IsActive");

		private void Start()
		{
			ResetSwitch();
		}

		public void SetConnection(ISwitchConnectable connectable)
		{
			connection = connectable;
		}

		private void ResetSwitch()
		{
			b_IsActive = b_InitialState;
			SetAnimation();
			b_IsActivatedOnce = false;
		}

		private void SetAnimation()
		{
			m_Animator.SetBool(anim_IsActive, b_IsActive);
		}

		protected override void Interact()
		{
			if (!b_IsMultiActivateable && b_IsActivatedOnce)
				return;

			b_IsActivatedOnce = true;
			b_IsActive = !b_IsActive;
			SetAnimation();
			connection.Switch(b_IsActive);
		}
	}
}
