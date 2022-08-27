using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Paralysed
{
    public class LevelLoaderDemo : MonoBehaviour
    { 
        
        private void OnCollisionEnter2D(Collision2D col)
        { 
            int currentlevel = SceneManager.GetActiveScene().buildIndex;
            if (col.gameObject.CompareTag("Player"))
            {
                if (currentlevel >= PlayerPrefs.GetInt("levelsUnlocked"))
                {
                    PlayerPrefs.SetInt("levelsUnlocked", currentlevel + 1);
                    SceneManager.LoadScene(currentlevel + 1);
                    Debug.Log("Completed");
                }
            }
        }
    }
}
