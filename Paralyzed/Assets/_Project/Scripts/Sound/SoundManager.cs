using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Sound
{
    public abstract class SoundManager : MonoBehaviour
    {
        [SerializeField] private AudioSource source;

        protected void PlayAudio(AudioClip audio)
		{
            source.clip = audio;
            source.Play();
		}
    }
}
