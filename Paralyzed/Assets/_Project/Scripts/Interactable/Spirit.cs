using UnityEngine;
using Paralysed.Message;

namespace Paralysed.Interactable
{
	public class Spirit : Interactable
	{
		[SerializeField] private MessageSO message;
		[SerializeField] private Transform RespawnPoint; 
		private MessageDisplayController messageDisplayController;
		
		private void Start()
		{
			messageDisplayController = MessageDisplayController.Instance;
		}
		protected override void Interact(Collider2D collider)
		{
			if(collider.TryGetComponent(out Core.IRespawnable respawnable))
			{
				messageDisplayController.ShowMessage(message);
				respawnable.SetRespawn(RespawnPoint.position);
			}
		}
	}
}
