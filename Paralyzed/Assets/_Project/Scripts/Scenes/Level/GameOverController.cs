using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.GameOver
{
    public class GameOverController : MonoBehaviour
    {
        public void Reload()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void Quit()
        {
			GameManager.Instance.sceneSwtichController.SwitchMenuScene(Scene.MenuSceneType.MainMenu);
        }
    }
}
