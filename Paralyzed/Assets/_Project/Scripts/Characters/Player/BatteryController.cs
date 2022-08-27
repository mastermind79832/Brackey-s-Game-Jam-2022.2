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

        [Header("Particle")]
        [SerializeField] private GameObject m_DeadParticle;
        private ParticleSystem m_ParticleSystem;

        private float m_CurrentHealth;

        private void Start()
        {
            m_CurrentHealth = m_MaxHealth;
            UpdateBattery();
           m_DeadParticle.SetActive(false);
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

            m_DeadParticle.SetActive(true);
            yield return new WaitForSeconds(.5f);
            transform.GetChild(1).gameObject.SetActive(false);
            m_ParticleSystem = m_DeadParticle.GetComponentInChildren<ParticleSystem>();
            m_ParticleSystem.Play();
        }

       
    }
}
