using System.Collections.Generic;
using UnityEngine;

namespace Paralysed.Core
{
    public class ObjectPool<T> where T : MonoBehaviour
    {
        private readonly Queue<T> m_Pool;
        private readonly T m_Prefab;

        public ObjectPool(T prefab)
		{
			m_Prefab = prefab;
			m_Pool = new Queue<T>();
		}

        public T GetItem()
		{
			if (IsEmpty())
				m_Pool.Enqueue(CreateItem());
			return m_Pool.Dequeue();
		}

		public bool IsEmpty() => m_Pool.Count == 0;
		public void PutItem(T item) => m_Pool.Enqueue(item);
		private T CreateItem() => Object.Instantiate(m_Prefab);
	}
}
