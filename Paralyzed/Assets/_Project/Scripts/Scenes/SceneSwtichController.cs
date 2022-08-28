using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.Scene
{
	public enum MainMenuSceneType
	{
		MainMenu = 0,
		LevelMenu = 1
	}

    public class SceneSwtichController : MonoBehaviour
    {
        [SerializeField] private SceneCollection m_MenuCollection;
		[SerializeField] private SceneCollection m_LevelCollection;

        public void SwitchMenuScene(MainMenuSceneType type)
		{
			LoadScene(m_MenuCollection,(int)type);
		}

		public void StartLevel(int levelIndex)
		{
			LoadScene(m_LevelCollection, levelIndex);
		}
		private void LoadScene(SceneCollection collection ,int menuIndex)
		{
			SceneManager.LoadScene(collection.SceneNames[menuIndex]);
		}
    }
}
