using System.Collections.Generic;
using UnityEngine;
using Paralysed.Core;
using Paralysed.Interactable;

namespace Paralysed.Obstacle
{
	public class LaserObstacle : Obstacle, ISwitchConnectable
    {
		[SerializeField] private EdgeCollider2D m_EdgeCollider;
        [SerializeField] private Transform m_StartPosition;
        [SerializeField] private Transform m_EndPosition;
		[SerializeField] private LineRenderer m_LineRenderer;
		[SerializeField] private Switch ConnectedSwitch;

		private void Start()
		{
			CreateLaser();
			if(ConnectedSwitch != null)
				ConnectedSwitch.SetConnection(this);
		}

		private void CreateLaser()
		{
			m_LineRenderer.SetPosition(0, m_StartPosition.localPosition);
			m_LineRenderer.SetPosition(1, m_EndPosition.localPosition);
			List<Vector2> points = new List<Vector2>();
			points.Add(m_StartPosition.localPosition);
			points.Add(m_EndPosition.localPosition);
			if (!m_EdgeCollider.SetPoints(points))
				Debug.LogError("Invalid");
		}

		public void Switch(bool active)
		{
			m_LineRenderer.gameObject.SetActive(active);
			m_EdgeCollider.enabled = active;
		}

	}
}
