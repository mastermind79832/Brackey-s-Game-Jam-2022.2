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
        public GameObject LoadPanel;
        public Slider slider;
        
        public void Start()
        {
            LoadPanel.SetActive(false);
        }

        public void Loadlevel(int sceneIndex)
        {
            StartCoroutine(LoadAsynchonously(sceneIndex));
        }

        IEnumerator LoadAsynchonously(int sceneIndex)
        {
            LoadPanel.SetActive(true);
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
            LoadPanel.SetActive(true);
            while (!operation.isDone)
            {
                float progress = Mathf.Clamp01(operation.progress / .9f);
                slider.value = progress;
                yield return null;
            }
        }
    }
}
