using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWASD : PlayerCharacters
{

    [SerializeField] private Collider2D crateBox;
    [SerializeField] private Collider2D playerBox;

    [SerializeField] private Rigidbody2D crateRb;
    public LayerMask onCrate;
    public override void Update()

    {
        base.Update();
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, 0.85f, onCrate);

        if (hit)
        {
            Debug.Log("on crate");
            rb2d.velocity = new Vector2(rb2d.velocity.x + crateRb.velocity.x, crateRb.velocity.y);
            rb2d.gravityScale = 1f;
        }
        else
        {
            rb2d.gravityScale = 0.9f;
        }

        if (Input.GetKey(KeyCode.W) && hit)
        {
            rb2d.AddForce(new Vector2(0f, -crateRb.velocity.y + jumpHeight/300));
            if (crateRb.velocity.y <= 0f)
            {

            }
        }

    }

    public void FixedUpdate()
    {
        
    }
}
