using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Paralysed.GameManager;

namespace Paralysed.Character
{
    public class BatteryController : MonoBehaviour
    {
        [Header("Health")]
        [SerializeField] private float m_MaxHealth;
        [SerializeField] private Image m_BatteryFill;

        [Header("Particle")]
        [SerializeField] private GameObject m_DeathParticle;

        
       
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

            if (m_CurrentHealth <= 0)
            {
                StartCoroutine(PlayerDeath());

            }
            
        }

        IEnumerator PlayerDeath()
        {
            m_DeathParticle = Instantiate(m_DeathParticle, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0f);
            GameManager.GameManager.Instance.CallGameOverPanel();
            this.transform.parent.GetChild(2).SetParent(null);
            transform.gameObject.SetActive(false);
            
        }

       
    }
}
