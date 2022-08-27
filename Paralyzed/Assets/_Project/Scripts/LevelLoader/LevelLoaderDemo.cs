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
                SceneManager.LoadScene(currentlevel + 1);
                if (currentlevel >= PlayerPrefs.GetInt("levelsUnlocked"))
                {
                    PlayerPrefs.SetInt("levelsUnlocked", currentlevel );
                    Debug.Log("Completed");
                }
            }
        }
    }
}
