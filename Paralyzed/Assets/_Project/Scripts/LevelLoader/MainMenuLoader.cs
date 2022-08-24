using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.Scene
{
    public class MainMenuLoader : MonoBehaviour
    {
        public Scene.SceneCollection menuSceneCollection;
        public enum Scenes
        {
            MainMenu = 0,
            Setting = 1,         
        }

        public void Play()
        {
            SceneManager.LoadScene(menuSceneCollection.SceneNames[(int)Scenes.MainMenu]);
        }

        public void OptionMenu()
        {
            SceneManager.LoadScene(menuSceneCollection.SceneNames[(int)Scenes.Setting]);
        }

        public void QuitApplication()
        {
            Application.Quit();
        }

    }
}


