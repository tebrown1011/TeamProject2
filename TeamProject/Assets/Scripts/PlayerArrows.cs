using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArrows : PlayerCharacters
{
    public Transform pickupPos;
    public Transform switchSpot;
    public Transform originalSpot;
    public override void Update()
    {
        base.Update();
        if (Input.GetKeyDown(Left))
        {
            playerSprite.flipX = false;
            pickupPos.position = originalSpot.position;
        }
        else if (Input.GetKeyDown(Right))
        {
            playerSprite.flipX = true;
            pickupPos.position = switchSpot.position;
        }
    }

}
