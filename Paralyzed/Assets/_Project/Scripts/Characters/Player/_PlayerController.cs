using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed
{
    public class _PlayerController : MonoBehaviour
    {
        private Rigidbody2D _rb;
       
        public float _CheckRadiius;
        public Transform _GroundCheck;

        public float _jumpForce;
        private float _jumpTimeCounter;
        public float _jumpTime;

        private bool _isGrounded;
        private bool _isJumping;


        public LayerMask _whatIsGround;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Jump();
        }

        private void Jump()
        {
            _isGrounded = Physics2D.OverlapCircle(_GroundCheck.position, _CheckRadiius, _whatIsGround);

            if(_isGrounded == true && Input.GetMouseButtonDown(1))
            {
                _isJumping = true;
                _jumpTimeCounter = _jumpTime;
                _rb.velocity = Vector2.up * _jumpForce;
            }
            if(Input.GetMouseButton(1) && _isJumping == true)
            {
                if(_jumpTimeCounter > 0)
                {
                    _rb.velocity = Vector2.up * _jumpForce;
                    _jumpTimeCounter -= Time.deltaTime;
                }
                else
                {
                    _isJumping = false;
                }
               
            }
            if(Input.GetMouseButtonUp(1) && _isGrounded == false)
            {
                _isJumping = false;
                
            }
        }

    }
}
