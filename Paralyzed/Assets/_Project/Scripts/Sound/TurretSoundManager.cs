using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Character
{
    public class TurretSoundManager : Sound.SoundManager
    {
        [SerializeField] private AudioClip m_FireClip;

        public void PlayFireSound()
		{
            PlayAudio(m_FireClip);
		}
    }
}
