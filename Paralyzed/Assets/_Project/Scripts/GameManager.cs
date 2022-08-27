using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Paralysed.Manager
{
    public class GameManager : MonoBehaviour
    {
       public static GameManager Instance { get; private set; }

       private void Awake()
       {
           if (Instance != null && Instance != this)
           {
               Destroy(this);
               return;
           }

           Instance = this;
           DontDestroyOnLoad(gameObject);
       }

       [SerializeField] private GameObject _gameOverScene;



       public void CallGameOverScene()
       {
           Instantiate(_gameOverScene, new Vector3(0, 0, 0), Quaternion.identity);
       }

    }
}
