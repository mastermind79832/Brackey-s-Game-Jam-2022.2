using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Paralysed
{
    public class HealthManager : MonoBehaviour
    {
        [Header("Health")]
        [SerializeField] private int m_MaxHealth;
        [SerializeField] private Image[] m_Hearts;
        [SerializeField] private int m_HeartsIndex;

        [Header("Game Status")]
        public static HealthManager Instance;

        private int m_CurrentHealth;

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
                return;
            }
            else
                Instance = this;
        }

        private void Start()
        {
            m_CurrentHealth = m_MaxHealth;
        }
        private void Update()
        {
            DisplayHearts();
        }
       
        public void DisplayHearts()
        {
            if(m_CurrentHealth >= m_MaxHealth)
            {
                m_CurrentHealth = m_MaxHealth;
            }
            if(m_CurrentHealth < 0)
            {
                m_CurrentHealth = 0;
            }

            for(int i = 0; i < m_Hearts.Length; i++)
            {
                m_HeartsIndex = Mathf.Abs(m_CurrentHealth - m_MaxHealth);
                m_Hearts[i].enabled = false;
                m_Hearts[m_HeartsIndex].enabled = true;
            }
        }

        public void HurtPlayer()
        {
            m_CurrentHealth--;
        }
    }
}
