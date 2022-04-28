using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCrate : MonoBehaviour
{
    [SerializeField] private Collider2D crateCol;
    [SerializeField] private Collider2D pickupCol;
    [SerializeField] private Collider2D holdCol;

    [SerializeField] private Rigidbody2D holdSpot;
    [SerializeField] private Rigidbody2D playerEarth;

    [SerializeField] private GameObject holdRef;
    [SerializeField] private GameObject crate;

    [SerializeField] private float throwForce;
    [SerializeField] private float holdBuffer;
    void Start()
    {
       
    }

    
    void Update()
    {
        Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();

        if (crateCol.IsTouching(pickupCol) && Input.GetKeyDown(KeyCode.P))
        {
            holdRef.GetComponent<HoldSpot>().isHolding = true;
            this.transform.position = holdSpot.transform.position;
        }


        if (holdRef.GetComponent<HoldSpot>().isHolding == true && crateCol.IsTouching(holdCol))
        {
            this.transform.position = holdSpot.transform.position;
            rb.velocity = new Vector2(playerEarth.velocity.x, 0f);

            if (Input.GetKeyDown(KeyCode.P))
            {
                holdRef.GetComponent<HoldSpot>().isHolding = false;
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(throwForce, 500f));
            }
        }

    }

    private void FixedUpdate()
    {
        
    }


    
}
