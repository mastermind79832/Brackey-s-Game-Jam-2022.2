using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using UnityEngine.SceneManagement;

namespace Paralysed.Level
{
    public class LevelManager : MonoBehaviour
    {
        private int levelsUnlocked;

        public Button[] buttons;
        // Start is called before the first frame update
        void Start()
        {
            //PlayerPrefs.DeleteKey("levelsUnlocked");
            levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].interactable = false;
            }
            
            for (int i = 0; i < levelsUnlocked; i++)
            {
                buttons[i].interactable = true;
            }
            
            Debug.Log(buttons.Length);

        }

        public void LoadLevel(int levelIndex)
        {
            SceneManager.LoadScene(levelIndex);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
