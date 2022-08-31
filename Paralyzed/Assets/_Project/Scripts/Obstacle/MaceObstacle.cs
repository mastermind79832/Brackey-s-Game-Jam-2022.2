using UnityEngine;

namespace Paralysed.Obstacle
{
	public class MaceObstacle : Obstacle
    {
		[Tooltip("This object will move from one way point to the other and then cycle back again")]
        [SerializeField] private Transform[] m_WayPoints;
		[Tooltip("Speed at which the object moves to way point")]
		[SerializeField] private float m_Speed;

		private int m_CurrentIndex;

		private void Start()
		{
			transform.position = m_WayPoints[0].position;
			if(m_WayPoints.Length > 1)
				m_CurrentIndex = 1;
			else
				m_CurrentIndex = 0;
		}

		private void FixedUpdate()
		{
			if (m_WayPoints == null || m_WayPoints.Length <= 1)
				return;
			Movement();
		}

		private void Movement()
		{
			transform.position = Vector3.MoveTowards(transform.position, m_WayPoints[m_CurrentIndex].position, m_Speed * Time.fixedDeltaTime);
			if (IsPointReached())
				SetNextPoint();
		}

		private void SetNextPoint()
		{
			m_CurrentIndex++;
			if (m_CurrentIndex >= m_WayPoints.Length)
				m_CurrentIndex = 0;
		}

		private bool IsPointReached() => transform.position == m_WayPoints[m_CurrentIndex].position;

	}
}
