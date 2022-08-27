using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed
{
    [RequireComponent(typeof(AudioSource))]
    public class _Audio : MonoBehaviour
    {
        [SerializeField] private AudioSource m_AudioSource;
        [SerializeField] private AudioClip m_Clip;
        [SerializeField] private bool b_IsPlaying;  
        [SerializeField] private bool b_IsPaused;   
        [SerializeField] private bool b_IsStopped;

        private void Start()
        {   
            m_AudioSource = GetComponent<AudioSource>();
        }
        public void play() 
        {
            m_AudioSource.Play();
        }
        public void pause() 
        {
            m_AudioSource.Pause();
        }       
    }
}
