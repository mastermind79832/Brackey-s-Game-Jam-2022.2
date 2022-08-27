using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Paralysed.Character
{
    public class BatteryController : MonoBehaviour
    {
        [Header("Health")]
        [SerializeField] private float m_MaxHealth;
        [SerializeField] private Image m_BatteryFill;

        private float m_CurrentHealth;

        private void Start()
        {
            m_CurrentHealth = m_MaxHealth;
            UpdateBattery();
        }
       
        public void UpdateBattery()
        {
            m_BatteryFill.fillAmount = m_CurrentHealth / m_MaxHealth;

        }

        public void Reduce(float value)
        {
            m_CurrentHealth -= value;
            UpdateBattery();
        }
    }
}
