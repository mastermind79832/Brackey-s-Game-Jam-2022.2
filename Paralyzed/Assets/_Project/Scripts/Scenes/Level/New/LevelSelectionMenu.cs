using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Scene
{
    public class LevelSelectionMenu : MonoBehaviour
    {
        [SerializeField] private LevelCollection m_levelCollection;
        [SerializeField] private LevelButtonController[] m_LevelButtons;
		
		private int levelsUnlocked;

		private void Start()
		{
			SetLevelButtons();
		}

		private void SetLevelButtons()
		{
			for (int i = 0; i < m_LevelButtons.Length; i++)
			{
				m_LevelButtons[i].SetLevelDetails(m_levelCollection.levelDetails[i], i);
			}

			SetUnlockedButton();
		}

		private void SetUnlockedButton()
		{
			//PlayerPrefs.DeleteKey("levelsUnlocked");  // to clear memory
			levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);

			for (int i = 0; i < m_LevelButtons.Length; i++)
			{
				m_LevelButtons[i].SetActive(false);
			}

			for (int i = 0; i < levelsUnlocked; i++)
			{
				m_LevelButtons[i].SetActive(true);
			}
		}
	}
}
