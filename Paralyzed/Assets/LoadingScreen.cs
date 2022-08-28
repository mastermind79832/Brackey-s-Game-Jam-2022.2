using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Paralysed
{
    public class LoadingScreen : MonoBehaviour
    {
        public GameObject LoadPannel;
        public Slider slider;


        public void Start()
        {
            LoadPannel.SetActive(false);
        }

        public void Loadlevel(int sceneIndex)
        {

            StartCoroutine(LoadAsynchonously(sceneIndex));
        }

        IEnumerator LoadAsynchonously(int sceneIndex)
        {
            LoadPannel.SetActive(true);
            AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
            LoadPannel.SetActive(true);
            while (!operation.isDone)
            {
                float progress = Mathf.Clamp01(operation.progress / .9f);
                slider.value = progress;
                yield return null;
            }
        }
    }
}
