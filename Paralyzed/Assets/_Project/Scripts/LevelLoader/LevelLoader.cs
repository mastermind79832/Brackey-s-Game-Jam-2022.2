using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed
{
    public static class LevelLoader
    {
       public enum Scenes
       {
           MainMenu,
           SampleScene,
           Reload,
           Options,
           Levels
       }

       public static void LoadScene(Scenes scene)
       {
           SceneManager.LoadScene(scene.ToString());
       }

       public static void QuitMenu()
       {
           Application.Quit();
       }
    }
}
