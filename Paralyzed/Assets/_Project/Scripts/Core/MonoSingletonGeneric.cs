using UnityEngine;

namespace Paralysed.Core
{
    public class MonoSingletonGeneric<T> : MonoBehaviour where T : MonoSingletonGeneric<T>
    {
        private static T instance;
        public static T Instance { get { return instance; } }

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
