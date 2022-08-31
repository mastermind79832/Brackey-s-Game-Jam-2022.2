using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Paralysed.Scene
{
    public class LoadingScreen : MonoBehaviour
    {
        [SerializeField] private Slider slider;
        
        public void Start()
        {
            gameObject.SetActive(false);
        }

        public void Loadlevel(string sceneName)
        {
            StartCoroutine(LoadAsynchonously(sceneName));
        }

        IEnumerator LoadAsynchonously(string sceneName)
        {
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
            while (!operation.isDone)
            {
                float progress = Mathf.Clamp01(operation.progress / .9f);
                slider.value = progress;
                yield return null;
            }
            gameObject.SetActive(false);
        }
    }
}
