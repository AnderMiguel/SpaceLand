using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject Player;
    Rigidbody2D rbPlayer;
    Rigidbody2D Camera;
    Player player;
    float OffSetX = 0;
    float OffSetY = 0;
    
    void Start()
    {
        rbPlayer = Player.GetComponent<Rigidbody2D>();
        Camera = GetComponent<Rigidbody2D>();

        player = Player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        OffSetX = Player.transform.position.x - transform.position.x;
        OffSetY = Player.transform.position.y - transform.position.y;


        if (player.fuel > 0)
        {
            if (OffSetX > 3 || OffSetX < -3)
            {
                Camera.velocity = new Vector2(rbPlayer.velocity.x, Camera.velocity.y);
            }

            else
            {
                Camera.velocity = new Vector2(0, Camera.velocity.y);
            }

            if (OffSetY > 2 || OffSetY < -2)
            {
                Camera.velocity = new Vector2(Camera.velocity.x, rbPlayer.velocity.y);
            }
            else
            {
                Camera.velocity = new Vector2(Camera.velocity.x, 0);
            }                        
        }

        else if (OffSetY < -5 || OffSetY > 5)
        {
            Camera.velocity = new Vector2(0, 0);
            player.Dead = true;
        }

        if (player.RestartCamPos == true) 
        {
            transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10);
        }
    }
}
