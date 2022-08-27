using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        
        
        
    }
}
