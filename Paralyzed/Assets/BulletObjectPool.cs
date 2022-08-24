using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Character
{
    public class BulletObjectPool : MonoBehaviour
    {
        public static BulletObjectPool instance;

        private List<GameObject> pooledObjects = new List<GameObject>();
        private int i_AmountToPool = 20;

        [SerializeField] private GameObject BulletPrefab;

        private void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }
        }

        private void Start()
        {
            for (int i = 0; i < i_AmountToPool; i++)
            {
                GameObject obj = Instantiate(BulletPrefab);
                obj.SetActive(false);
                pooledObjects.Add(obj);
            }
        }

        public GameObject GetPooledObjects()
        {
            for (int i = 0; i < pooledObjects.Count; i++)
            {
                if(!pooledObjects[i].activeInHierarchy)
                {
                    return pooledObjects[i];
                }
            }
            return null;
        }
    }
}
