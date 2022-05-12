using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWASD : PlayerCharacters
{
    public LayerMask onCrate;
    public Collider2D col;
    public override void Update()

    {
        base.Update();
        if (Input.GetKey(Left))
        {
            col.offset = new Vector2(-0.1f, 0f);
        }

        if (Input.GetKey(Right))
        {
            col.offset = new Vector2(0.1f, 0f);
        }


        if (Input.GetKeyDown(Left))
        {
            playerSprite.flipX = true;
        }
        else if (Input.GetKeyDown(Right))
        {
            playerSprite.flipX = false;
        }


        RaycastHit2D hit = Physics2D.CircleCast(transform.position, 0.5f, Vector2.down, 0.8f, onCrate);

        if (hit)
        {
            Debug.Log("on crate");
            rb2d.velocity = new Vector2(rb2d.velocity.x + hit.rigidbody.velocity.x +0.1f, rb2d.velocity.y);
            rb2d.gravityScale = 1f;
            ani.SetBool("isGrounded", true);
        }
        else
        {
            rb2d.gravityScale = 0.9f;
        }

        if (Input.GetKeyDown(KeyCode.W) && hit)
        {
            rb2d.AddForce(new Vector2(0f, jumpHeight - 50));
        }

    }

    public void FixedUpdate()
    {
        
    }
}
