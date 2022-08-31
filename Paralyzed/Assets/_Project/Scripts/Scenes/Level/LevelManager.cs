using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed.Scene
{
    public class LevelManager : MonoBehaviour
    {
        public int CurrentLevel { get; private set; }
        public void UnlockNextLevel()
		{
            CurrentLevel++;

            if (CurrentLevel >= PlayerPrefs.GetInt("levelsUnlocked"))
                PlayerPrefs.SetInt("levelsUnlocked", CurrentLevel);
        }

		public void SetCurrentLevel(int levelIndex)
		{
			CurrentLevel = levelIndex + 1;
		}

        public int GetUnlockedLevelCount()
		{
            return PlayerPrefs.GetInt("levelsUnlocked", 1);

        }
	}
}
