using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Paralysed.Scene
{
    public class LevelButtonController : MonoBehaviour
    {
        [SerializeField] private Button m_Button;
        [SerializeField] private TextMeshProUGUI m_ChapterTitle;
        [SerializeField] private Image m_BackgroundImage;
        [SerializeField] private Image m_DarkenImage;

		private int m_levelIndex;

		private void Start()
		{
            m_Button.onClick.AddListener(OnButtonPressed);
		}

		public void SetLevelDetails(LevelDetail level, int index)
		{
            m_BackgroundImage.sprite = level.bgImage;
            m_ChapterTitle.text = level.levelTitle;
            m_levelIndex = index;
		}

		public void SetActive(bool isActive)
		{
            m_Button.interactable = isActive;
            if (!isActive)
                m_DarkenImage.color = new Color(0, 0, 0, 0.8f);
            else
                m_DarkenImage.color = new Color(0, 0, 0, 0);
        }

        private void OnButtonPressed()
		{
            GameManager.Instance.StartLevel(m_levelIndex);
		}
    }
}
