using System;
using UnityEngine;
using TMPro;
using Paralysed.Core;

namespace Paralysed.Message
{
	public class MessageDisplayController : MonoSingletonGeneric<MessageDisplayController>
    {
        [SerializeField] private GameObject m_MessagePanel;
        [SerializeField] private TextMeshProUGUI m_TitleText;
		[SerializeField] private TextMeshProUGUI m_Content;
        [SerializeField] private TextMeshProUGUI m_ButtonText;

        private Action m_OnButtonPressed;

        public void OnButtonPressed()
		{
            Close();
            m_OnButtonPressed?.Invoke();
		}

		private void Close()
		{
			m_MessagePanel.SetActive(false);
			Time.timeScale = 1;
		}

		public void ShowMessage(MessageSO message, Action onButtonPressed = null)
		{
			Time.timeScale = 0;
			m_TitleText.text = message.TitleText;
			m_Content.text = message.MessageText;
			m_ButtonText.text = message.ButtonText;
			m_OnButtonPressed = onButtonPressed;
			m_MessagePanel.SetActive(true);
		}
    }
}
