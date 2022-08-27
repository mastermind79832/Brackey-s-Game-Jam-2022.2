using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed
{
    public class GameOver : MonoBehaviour
    {
        public void Retry()
        {
            int currentlevel = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentlevel);
        }

        public void QuitApplication()
        {
            Application.Quit();
        }
        
    }
}
