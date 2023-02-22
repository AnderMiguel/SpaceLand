using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsInGame : MonoBehaviour
{
    GameObject oPlayer;
    public GameObject starCount;
    float ColorChange = 0;
    float Dist = 0;
    Renderer rend;


    Player player;
    StarCount Starcount;

    int thisCount = 0;

    public GameObject Star1, Star2, Star3;    




    // Start is called before the first frame update
    void Start()
    {
        oPlayer = GameObject.FindGameObjectWithTag("Player");

        player = oPlayer.GetComponent<Player>();

        rend = GetComponent<Renderer>();
        Starcount = starCount.GetComponent<StarCount>();
    }

    // Update is called once per frame
    void Update()
    {
        Dist = Vector2.Distance(oPlayer.transform.position, transform.position);

        if (Dist < 1)
        {
            ColorChange -= 5 * Time.deltaTime;
            rend.material.color = new Color(1, 1, 1, ColorChange);
            Starcount.StageStarCount = Starcount.StageStarCount + 1;

            player.CheckPointPos = transform.position;

            thisCount++;

            if (ColorChange <= 0)
            {
                ColorChange = 0;                
                Destroy(gameObject);
                
            }
        }
    }
}
