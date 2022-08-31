using UnityEngine;

namespace Paralysed.Scene
{
    public class LevelSelectionMenu : MonoBehaviour
    {
        [SerializeField] private LevelCollection m_LevelCollection;
        [SerializeField] private LevelButtonController[] m_LevelButtons;
		
		private int levelsUnlocked;

		private void Start()
		{
			SetLevelButtons();
			SetButtonActive(m_LevelButtons.Length, false);
			SetUnlockedButton();
		}

		private void SetLevelButtons()
		{
			for (int i = 0; i < m_LevelButtons.Length; i++)
				m_LevelButtons[i].SetLevelDetails(m_LevelCollection.levelDetails[i], i);

			SetUnlockedButton();
		}

		private void SetUnlockedButton()
		{
			//PlayerPrefs.DeleteKey("levelsUnlocked");  // to clear memory
			levelsUnlocked = GameManager.Instance.LevelManager.GetUnlockedLevelCount();
			SetButtonActive(levelsUnlocked, true);
		}

		private void SetButtonActive(int count, bool isActive)
		{
			for (int i = 0; i < count; i++)
				m_LevelButtons[i].SetActive(isActive);
		}
	}
}
