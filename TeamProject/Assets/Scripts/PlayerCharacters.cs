using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacters : MonoBehaviour
{
    public int speed;
    public int gravity;

    public string HorizontalInput;

    public KeyCode Jump;
    private float thrust = 1f;
    

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw(HorizontalInput);
        float yMove = Input.GetAxisRaw("Vertical");
        rb2d.velocity = new Vector2(xMove * speed, -1 * gravity);

        if (Input.GetKeyDown(Jump))
        {
            Debug.Log("Jump");
            rb2d.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }
    }
}
