using UnityEngine;
using Button = UnityEngine.UI.Button;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


namespace Paralysed.Level
{
    public class LevelManager : MonoBehaviour
    {
        [Header("Level Loader")]
        [SerializeField] private Button[] m_Button;
        private int levelsUnlocked;

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
    }
}
