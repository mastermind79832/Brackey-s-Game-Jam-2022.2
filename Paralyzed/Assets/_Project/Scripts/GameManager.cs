using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

namespace Paralysed.GameManager
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

        [SerializeField] private GameObject gameOverPanel;


        public void CallGameOverPanel()
        {
            Instantiate(gameOverPanel, Vector3.zero, quaternion.identity);
        }


    }
}
