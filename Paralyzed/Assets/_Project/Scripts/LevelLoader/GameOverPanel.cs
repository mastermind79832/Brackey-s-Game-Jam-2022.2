using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.GameOver
{
    public class GameOverPanel : MonoBehaviour
    {
        public void Reload()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}
