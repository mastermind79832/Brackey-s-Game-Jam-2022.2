using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Paralysed.Core;

namespace Paralysed
{
    public class GameManager : MonoSingletonGeneric<GameManager>
    {
        [SerializeField] private GameObject gameOverPanel;
        [SerializeField] private Scene.SceneSwtichController sceneController;
        public Scene.SceneSwtichController sceneSwtichController { get { return sceneController; } }    

		protected override void Awake()
		{
			base.Awake();
            DontDestroyOnLoad(gameObject);
		}

		public void CallGameOverPanel()
        {
            Instantiate(gameOverPanel, Vector3.zero, quaternion.identity);
            Time.timeScale = 0;
        }
    }
}
