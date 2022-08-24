using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Paralysed.Message;

namespace Paralysed.Interactable
{
	public class Spirit : Interactable
	{
		[SerializeField]
		private MessageSO message;

		private MessageDisplayController messageDisplayController;
		private void Start()
		{
			messageDisplayController = MessageDisplayController.Instance;
		}
		protected override void Interact()
		{
			messageDisplayController.ShowMessage(message);
		}
	}
}
