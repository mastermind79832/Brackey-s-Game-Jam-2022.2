using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.Scene
{
    public class MainMenuLoader : MonoBehaviour
    {
        [SerializeField]public Scene.SceneCollection menuSceneCollection;
        [SerializeField] private GameObject OptionPanel;
        public enum Scenes
        {
            MainMenu = 0,
            Setting = 1,         
        }

        public void Play()
        {
            SceneManager.LoadScene(menuSceneCollection.SceneNames[0]);
            
        }

        public void OptionMenu()
        {
            SceneManager.LoadScene(menuSceneCollection.SceneNames[1]);
        }

        public void QuitApplication()
        {
            Application.Quit();
        }

        public void ToggelPanel()
        {
            if (OptionPanel != null)
            {
                bool isActive = OptionPanel.activeSelf;
                
                OptionPanel.SetActive(!isActive);
            }
        }

    }
}


