using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed
{
    public class LaserObstacle : MonoBehaviour
    {
        [SerializeField] private Transform m_StartPosition;
        [SerializeField] private Transform m_EndPosition;
		[SerializeField] private LineRenderer m_LineRenderer;

		private void Start()
		{
			m_LineRenderer.SetPosition(0, m_StartPosition.localPosition);
			m_LineRenderer.SetPosition(1, m_EndPosition.localPosition);
			m_LineRenderer.gameObject.AddComponent<BoxCollider2D>();
		}
	}
}
