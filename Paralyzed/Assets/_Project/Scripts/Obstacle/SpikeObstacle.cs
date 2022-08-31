using UnityEngine;

namespace Paralysed.Obstacle
{
	public class SpikeObstacle : Obstacle
    {
        [Tooltip("will be stationary if turned off")]
        [SerializeField] private bool b_IsRectractable;
        [SerializeField] private float m_RectractDistance;
        [SerializeField] private float m_RectractSpeed;
        [SerializeField] private float m_RectractInterval;

        private float m_Timer;
		private Vector3 m_RectractedPosition;
		private Vector3 m_StartingPosition;
		private Vector3 m_NextPosition;

		private void Start()
		{
			SetRectractedPosition();
			SetObjectToStatic();
            m_Timer = 0;
			m_NextPosition = m_RectractedPosition;
		}

		private void SetRectractedPosition()
		{
			m_StartingPosition = transform.position;
			m_RectractedPosition = transform.position + transform.up * m_RectractDistance;
		}

		private void SetObjectToStatic() => gameObject.isStatic = !b_IsRectractable;

		private void Update()
		{
			if (!b_IsRectractable)
				return;

			IncreaseTimer();
		}

		private void FixedUpdate()
		{
			if (!b_IsRectractable)
				return;

			Movement();
		}

		private void IncreaseTimer()
		{
			m_Timer += Time.deltaTime;
			if(m_Timer >= m_RectractInterval)
			{
				m_NextPosition = (m_NextPosition == m_StartingPosition) ? m_RectractedPosition : m_StartingPosition;
				m_Timer = 0;
			}
		}

		private void Movement()
		{
			transform.position = Vector3.MoveTowards(transform.position, m_NextPosition, m_RectractSpeed * Time.fixedDeltaTime);
	
		}	
	}
}
