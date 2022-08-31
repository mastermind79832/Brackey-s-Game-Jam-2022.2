using UnityEngine;

namespace Paralysed.Obstacle
{
	public class StarObstacle : Obstacle
    {
		[Tooltip("angle to rotate per second")]
        [SerializeField] private float m_RotationSpeed;

		private void FixedUpdate()
		{
			transform.eulerAngles += m_RotationSpeed * Time.fixedDeltaTime * Vector3.forward;
		}
	}
}
