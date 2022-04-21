using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] private Transform pickupSpot;
    [SerializeField] private Transform playerPos;
    [SerializeField] private Transform holdSpot;
    [SerializeField] private GameObject crate;
    public GameObject holdRef;
    [SerializeField] private Collider2D pickupBox;
    [SerializeField] private Collider2D crateBox;
    [SerializeField] private Rigidbody2D rbCrate;
    [SerializeField] private float throwForce;

    void Start()
    {
        
    }

    void Update()
    {

        transform.position = new Vector3(transform.position.x, playerPos.transform.position.y, 0f);
        holdSpot.transform.position = new Vector3(playerPos.transform.position.x, holdSpot.transform.position.y, 0f);

        if (Input.GetKeyDown(KeyCode.U) && pickupBox.IsTouching(crateBox))
        {
            holdRef.GetComponent<HoldSpot>().isHolding = true;

        }

        if (holdRef.GetComponent<HoldSpot>().isHolding == true)
        {
            crate.transform.position = holdSpot.transform.position;
            rbCrate.velocity = new Vector2(0f, 0f);
        }

        if (holdRef.GetComponent<HoldSpot>().isHolding == true && Input.GetKey(KeyCode.O))
        {
            rbCrate.AddForce(new Vector2(throwForce, 100f));
            holdRef.GetComponent<HoldSpot>().isHolding = false;
        }

    }

    private void FixedUpdate()
    {
       
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
