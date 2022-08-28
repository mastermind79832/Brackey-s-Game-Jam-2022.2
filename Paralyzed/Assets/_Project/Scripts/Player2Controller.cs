using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paralysed
{
    public class Player2Controller : MonoBehaviour
    {
        float dirX;

        public float moveSPeed = 10f;
        // Update is called once per frame
        void Update()
        {
            dirX = Input.GetAxis("Horizontal");

            transform.position = new Vector2(transform.position.x + dirX * moveSPeed * Time.deltaTime, transform.position.y);
        }
    }
}
