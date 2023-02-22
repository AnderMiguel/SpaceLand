using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject Player;
    float Dist;

    float ColorChange = 1;
    Renderer rend;

   void Start () 
    {
        rend = GetComponent<Renderer>();
    }

    void Update () 
    {        
        Dist = Vector2.Distance(Player.transform.position, transform.position);
        

        if (Dist < 2)
        {
            ColorChange -= 1 * Time.deltaTime;
            rend.material.color = new Color(1, 1, 1, ColorChange);

            if (ColorChange <= 0) 
            {
                ColorChange = 0;
            }
        }

        else 
        {            rend.material.color = new Color(1, 1, 1, ColorChange);
            ColorChange += 1 * Time.deltaTime;
            if (ColorChange >= 1)
            {
                
                ColorChange = 1;
            }
        }



    }
}
