using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.Scene
{
    public class WinController : MonoBehaviour
    {
		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision.gameObject.GetComponent<Character.PlayerController>() != null)
			{
				GameManager.Instance.PlayNextLevel();
			}
		}
	}
}
