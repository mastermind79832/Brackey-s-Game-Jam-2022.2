using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed
{
    public class LevelChanger : MonoBehaviour
    {
       public void Play()
       {
            LevelLoader.LoadScene(LevelLoader.Scenes.SampleScene);
       
       }
       
       public void LevelSelection()
       {
           LevelLoader.LoadScene(LevelLoader.Scenes.Levels);
       
       }
       
       public void OptionMenu()
       {
           LevelLoader.LoadScene(LevelLoader.Scenes.Options);
       
       }

       public void QuitApplication()
       {
           LevelLoader.QuitMenu();
       }
       
    }
}
