using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerStats : MonoBehaviour
    {
        [SerializeField] public Vector3 playerPos;
        [SerializeField] public Vector3 playerRayPos;
        [SerializeField] public float playerSpeed;
        [SerializeField] public Rigidbody2D rb;
        [SerializeField] public float jumpForce;
        [SerializeField] public Transform playerTrans;
        public float virtualSpeed;
        public virtual void Start()
        {
            
        }

        public virtual void Update()
        {
            //MOVING PLAYER//
            float moveForward = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
            transform.position += new Vector3(moveForward, 0f);
            virtualSpeed = moveForward;
            rb.velocity = new Vector2(playerPos.x, rb.velocity.y);

            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.AddForce(new Vector2(0f, jumpForce));
            }

            playerRayPos = playerTrans.position;
        }

       

    }
}
