using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.Scene
{
    public class GameOverController : MonoBehaviour
    {
        public void Reload()
        {
            Time.timeScale = 1;
            GameManager.Instance.ReplayLevel();
            SetInactive();
        }

		public void Quit()
        {
			GameManager.Instance.SceneController.SwitchMenuScene(Scene.MenuSceneType.MainMenu);
            SetInactive();
        }
		private void SetInactive()
		{
			gameObject.SetActive(false);
		}
    }
}
