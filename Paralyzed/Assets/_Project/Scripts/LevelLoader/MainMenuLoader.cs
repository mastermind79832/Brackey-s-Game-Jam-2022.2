using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.Scene
{
    public class MainMenuLoader : MonoBehaviour
    {
        [Header("SceneManagement")]
        [SerializeField]private Scene.SceneCollection m_menuSceneCollection;
        [SerializeField]private GameObject m_OptionPanel;
        public enum Scenes
        {
            MainMenu = 0,
            Setting = 1,         
        }

        public void Play()
        {
            SceneManager.LoadScene(m_menuSceneCollection.SceneNames[0]);
            
        }

        public void OptionMenu()
        {
            SceneManager.LoadScene(m_menuSceneCollection.SceneNames[1]);
        }

        public void QuitApplication()
        {
            Application.Quit();
        }

        public void ToggelPanel()
        {
            if (m_OptionPanel != null)
            {
                bool isActive = m_OptionPanel.activeSelf;
                
                m_OptionPanel.SetActive(!isActive);
            }
        }

    }
}


