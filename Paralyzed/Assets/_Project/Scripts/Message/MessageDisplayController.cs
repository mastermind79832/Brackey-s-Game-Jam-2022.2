using System;
using System.Collections.Generic;
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
            close();
            m_OnButtonPressed?.Invoke();
		}

		private void close()
		{
			m_MessagePanel.SetActive(false);
		}

		public void ShowMessage(MessageSO message, Action onButtonPressed = null)
		{
			m_TitleText.text = message.TitleText;
			m_Content.text = message.MessageText;
			m_ButtonText.text = message.ButtonText;
			m_OnButtonPressed = onButtonPressed;
			m_MessagePanel.SetActive(true);
		}
    }
}
