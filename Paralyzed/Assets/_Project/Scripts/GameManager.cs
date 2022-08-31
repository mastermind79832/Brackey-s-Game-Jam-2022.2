using UnityEngine;
using Paralysed.Core;
using Paralysed.Scene;

namespace Paralysed
{
    public class GameManager : MonoSingletonGeneric<GameManager>
    {
        [SerializeField] private GameOverController gameOverController;
        [SerializeField] private SceneSwtichController sceneController;
		[SerializeField] private LevelManager levelManager;
        [SerializeField] private GameObject restartButton;

        public SceneSwtichController SceneController { get { return sceneController; } }
        public LevelManager LevelManager { get { return levelManager; } }

		protected override void Awake()
		{
			base.Awake();
            DontDestroyOnLoad(gameObject);
		}

		public void GameOver()
        {
            Time.timeScale = 0;
            gameOverController.gameObject.SetActive(true);
        }

        public void PlayNextLevel()
		{
            if (LevelManager.CurrentLevel + 1 <= sceneController.GetTotalScene())
            {
                levelManager.UnlockNextLevel();
                sceneController.StartLevel(levelManager.CurrentLevel - 1);
            }
            else
			{
                sceneController.SwitchMenuScene(MenuSceneType.MainMenu);
			}
		}

        public void RestartButtonActive(bool isActive) => restartButton.SetActive(isActive);

        public void ReplayLevel()
		{
            sceneController.StartLevel(levelManager.CurrentLevel - 1);
        }

        public void StartLevel(int levelIndex)
		{
            levelManager.SetCurrentLevel(levelIndex);
            sceneController.StartLevel(levelIndex);
            restartButton.SetActive(true);
		}
    }
}
