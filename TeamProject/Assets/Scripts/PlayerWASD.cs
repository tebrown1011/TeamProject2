using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWASD : PlayerCharacters
{

    [SerializeField] private Collider2D crateBox;
    [SerializeField] private Collider2D playerBox;

    [SerializeField] private Rigidbody2D crateRb;
    public LayerMask detect;
    public override void Update()
    {
        base.Update();
    }

    public void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.down, 1f, detect);

        if (hit.collider == crateBox)
        {
            Debug.Log("on crate");
            rb2d.velocity = new Vector2(rb2d.velocity.x + crateRb.velocity.x, rb2d.velocity.x + crateRb.velocity.y);
        }

    }
}
