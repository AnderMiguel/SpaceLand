using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontCollider : MonoBehaviour
{
    Rigidbody2D rb;
    public bool Collision = false;   
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void OnCollisionEnter2D (Collision2D col) 
    {
    if (col.gameObject.tag == "Mars" || col.gameObject.tag == "Death")
        {
            Collision = true;
        }   
        
    }
}
