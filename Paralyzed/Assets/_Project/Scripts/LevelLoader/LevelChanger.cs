using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed
{
    public class LevelChanger : MonoBehaviour
    {
        public Scene.SceneCollection menuSceneCollection;
        public enum Scenes
        {
            MainMenu = 0,
            Setting = 1,
            Levels = 2,
        }

       public void Play()
       {
            SceneManager.LoadScene(menuSceneCollection.SceneNames[(int)Scenes.MainMenu]);
       }
       
       public void LevelSelection()
       {
            SceneManager.LoadScene(menuSceneCollection.SceneNames[(int)Scenes.Levels]);
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
