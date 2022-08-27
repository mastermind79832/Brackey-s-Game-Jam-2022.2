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
         [Header("Level Loader")]
         [SerializeField] private Button[] m_Button;
         private int levelsUnlocked;

        // Start is called before the first frame update
        void Start()
        {
            //PlayerPrefs.DeleteKey("levelsUnlocked");  // to clear memory
            levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);

            for (int i = 0; i < m_Button.Length; i++)
            {
                m_Button[i].interactable = false;
            }
            
            for (int i = 0; i < levelsUnlocked; i++)
            {
                m_Button[i].interactable = true;
            }
            
            Debug.Log(m_Button.Length);

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
