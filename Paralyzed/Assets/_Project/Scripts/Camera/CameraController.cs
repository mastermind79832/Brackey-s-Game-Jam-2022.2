using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Cinemachine;
using Paralysed.Core;


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
