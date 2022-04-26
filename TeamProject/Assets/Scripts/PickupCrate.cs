using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCrate : MonoBehaviour
{
    [SerializeField] private Transform holdSpot;
    [SerializeField] private GameObject holdRef;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float throwForce;
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float holdBuffer;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (holdRef.GetComponent<HoldSpot>().isHolding == true)
        {
            holdBuffer += 0.01f * Time.deltaTime;
            transform.position = holdSpot.position;
            rb.velocity = new Vector2(playerRb.velocity.x,0f);
            rb.isKinematic = true;

            if (Input.GetKeyDown(KeyCode.P) && holdRef.GetComponent<HoldSpot>().isHolding == true && holdBuffer >= 0.01f)
            {
                rb.isKinematic = false;
                holdRef.GetComponent<HoldSpot>().isHolding = false;
                rb.AddForce(new Vector2(throwForce, 50f));
                holdBuffer = 0f;
            }
            }
    }

    private void FixedUpdate()
    {
        /*if (Input.GetKeyDown(KeyCode.P) && holdRef.GetComponent<HoldSpot>().isHolding == true)
        {
            holdRef.GetComponent<HoldSpot>().isHolding = false;
            rb.AddForce(new Vector2(throwForce, 50f));
        }*/
       
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pickup" && Input.GetKey(KeyCode.P))
        {
            transform.position = holdSpot.position;
            holdRef.GetComponent<HoldSpot>().isHolding = true;
            Debug.Log("pick up");
        }
    }
}
