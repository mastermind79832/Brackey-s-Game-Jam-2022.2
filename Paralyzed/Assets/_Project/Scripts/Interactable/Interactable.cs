using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Interactable
{
    public abstract class Interactable : MonoBehaviour
    {
		private void OnTriggerEnter2D(Collider2D collision)
		{
			//if(player)
			Interact();
		}

		protected abstract void Interact();
	}
}
