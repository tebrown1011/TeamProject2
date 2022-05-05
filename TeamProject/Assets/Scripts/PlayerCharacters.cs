using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacters : MonoBehaviour
{
    public int speed;
    public int gravity;
    public float jumpHeight;

    public string HorizontalInput;
    public KeyCode Jump;
    public KeyCode Left;
    public KeyCode Right;
    public Rigidbody2D rb2d;

    public SpriteRenderer playerSprite;

    public Animator ani;

    private bool IsGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        float xMove = Input.GetAxisRaw(HorizontalInput);
        float yMove = Input.GetAxisRaw("Vertical");
        rb2d.velocity = new Vector2(xMove * speed, rb2d.velocity.y);

        /*if(rb2d.velocity.y <= 0)
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
        }
        */

        if (Input.GetKeyDown(Jump))
        {
            if(IsGrounded == true)
            {
                rb2d.AddForce(new Vector2(0f, jumpHeight));
            }
            
        }

        if (Input.GetKeyDown(Left))
        {
            playerSprite.flipX = true;
        } 
        else if (Input.GetKeyDown(Right))
        {
            playerSprite.flipX = false;
        }

        if (Input.GetKey(Left) || Input.GetKey(Right))
        {
            ani.SetBool("isRunning", true);
        }
        else
        {
            ani.SetBool("isRunning", false);
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        IsGrounded = true;
        ani.SetBool("isGrounded", true);
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        IsGrounded = false;
        ani.SetBool("isGrounded", false);
    }
}
