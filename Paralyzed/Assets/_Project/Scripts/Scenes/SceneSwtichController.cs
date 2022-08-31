using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.Scene
{

	public class SceneSwtichController : MonoBehaviour
	{
		[SerializeField] private LevelCollection m_LevelCollection;
		[SerializeField] private LoadingScreen m_LoadingScreen;

		public void SwitchMenuScene(MenuSceneType type)
		{
			GameManager.Instance.RestartButtonActive(false);
			SceneManager.LoadScene((int)type);
		}

		public void StartLevel(int levelIndex)
		{
			m_LoadingScreen.gameObject.SetActive(true);
			m_LoadingScreen.Loadlevel(m_LevelCollection.levelDetails[levelIndex].levelSceneName);
		}
		public int GetTotalScene() => m_LevelCollection.levelDetails.Length;
    }
}
