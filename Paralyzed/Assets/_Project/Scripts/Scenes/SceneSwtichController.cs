using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.Scene
{

	public class SceneSwtichController : MonoBehaviour
    {
		[SerializeField] private LevelCollection m_LevelCollection;

        public void SwitchMenuScene(MenuSceneType type)
		{
			SceneManager.LoadScene((int)type);
		}

		public void StartLevel(int levelIndex)
		{
			SceneManager.LoadScene(m_LevelCollection.levelDetails[levelIndex].levelSceneName);
		}
    }
}
