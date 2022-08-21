using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Core
{
    public class MonoSingletonGeneric<T> : MonoBehaviour where T : MonoSingletonGeneric<T>
    {
        private T instance;
        public T Instance { get { return instance; } }

		protected virtual void Awake()
		{
			CreateSingleton();
		}

		private void CreateSingleton()
		{
			if (instance != null)
			{
				Destroy(gameObject);
				return;
			}
			else
				instance = (T)this;
		}
	}
}
