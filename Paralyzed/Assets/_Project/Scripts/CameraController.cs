using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.Cinemachine;
using System;
=======
using Cinemachine;
using Paralysed.Core;
>>>>>>> 7c5f7b86508a319b58b9b03896a0dd19a961fe27

namespace Paralysed.Camera
{
    public class CameraController : MonoSingletonGeneric<CameraController>
    {
		[SerializeField] private CinemachineVirtualCamera virtualCamera;
        private CinemachineBasicMultiChannelPerlin noise;

		private void Start()
		{
            noise = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();	
		}

        public void CameraShake(float interval, float amplitude)
        {
            StartCoroutine(StartCameraShake(interval, amplitude));
        }

        IEnumerator StartCameraShake(float interval, float amplitude)
        {
            noise.m_AmplitudeGain = amplitude;
            yield return new WaitForSeconds(interval);
            noise.m_AmplitudeGain = 0;
        }

    }
}
