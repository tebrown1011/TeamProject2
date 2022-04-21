using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Strong : PlayerStats
    {
        public override void Start()
        {

        }

        public override void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.AddForce(new Vector2(0f, jumpForce));

            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-playerSpeed * Time.deltaTime, 0f, 0f);

            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(playerSpeed* Time.deltaTime, 0f, 0f);

            }
        }
    }
}
