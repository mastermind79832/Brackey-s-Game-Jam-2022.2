using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Paralysed.Core;

namespace Paralysed.Character
{
    public class TurretController : MonoBehaviour
    {
        [SerializeField] private Bullet bulletPrefab;

		[Header("Shooting properties")]
        [SerializeField] private float m_LaunchForce;
        [SerializeField] private Transform m_ShotPoint;

        //points
		[Header("Aim Direction Points")]
        [SerializeField] private GameObject m_PointPrefab;
        private GameObject[] m_Points;
        [SerializeField] private int m_TotalPointCount;
        [SerializeField] private float m_SpaceBetweenPoints;

        private Vector2 m_Direction;
		private ObjectPool<Bullet> m_BulletPool;

        private void Start()
		{
			InitializePoints();
			m_BulletPool = new ObjectPool<Bullet>(bulletPrefab);
		}

		private void InitializePoints()
		{
			m_Points = new GameObject[m_TotalPointCount];
			for (int i = 0; i < m_TotalPointCount; i++)
			{
				m_Points[i] = Instantiate(m_PointPrefab, m_ShotPoint.position, Quaternion.identity);
			}
		}

		void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }

		private void FixedUpdate()
		{
			SetTurretPosition();
			SetPoints();
		}

		private void SetTurretPosition()
		{
			Vector2 gunPosition = transform.position;
			Vector2 mousePosition = UnityEngine.Camera.main.ScreenToWorldPoint(Input.mousePosition);
			m_Direction = mousePosition - gunPosition;
			transform.up = m_Direction;
		}

		private void SetPoints()
		{
			for (int i = 0; i < m_TotalPointCount; i++)
			{
				m_Points[i].transform.position = PointPosition(i * m_SpaceBetweenPoints);
			}
		}

		void Shoot()
        {
			Bullet bullet = m_BulletPool.GetItem();
			bullet.transform.position = m_ShotPoint.position;
			bullet.gameObject.SetActive(true);
			bullet.AddVelocity(transform.up * m_LaunchForce);
			if(bullet.OnBulletDisable == null)
			bullet.OnBulletDisable = m_BulletPool.PutItem;
        }

        Vector2 PointPosition(float t)
        {
            //Formulae :- Position = StartingPos + StartingVelocity * t + 0.5 * Acceleration * (t * t)

            Vector2 position = (Vector2)m_ShotPoint.position + (m_Direction.normalized * m_LaunchForce * t) + 0.5f * Physics2D.gravity * (t * t);
            return position;
        }

		
		
    }
}
