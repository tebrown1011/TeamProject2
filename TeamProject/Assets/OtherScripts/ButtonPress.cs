using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    [SerializeField] private SpriteRenderer wall;
    [SerializeField] private Collider2D wallBox;
    [SerializeField] private Color wallOpen;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            wall.color = wallOpen;
            wallBox.enabled = false;
        }
    }
}
