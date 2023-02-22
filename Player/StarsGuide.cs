using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsGuide : MonoBehaviour
{
    public GameObject StarG1, StarG2, StarG3;
    
    public float Dist;
    public GameObject MainCamera;

    float ColorChange = 1;
    Renderer rend;

    public int StarChoice = 0;
    
    //float varY = 0;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        

        if (gameObject.name == "StarGuide")
        {
            StarChoice = 2;
        }
        else if (gameObject.name == "StarGuide (1)")
        {
            StarChoice = 1;
        }
        else if (gameObject.name == "StarGuide (2)")
        {
            StarChoice = 0;
        }

        StarG1 = GameObject.Find("Star");
        StarG2 = GameObject.Find("Star (1)");
        StarG3 = GameObject.Find("Star (2)");
        
    }

    // Update is called once per frame
    void Update()
    {       


        if (StarChoice == 0)
        {
            if (StarG1 != null)
            {                
                Vector3 dir = StarG1.transform.position - transform.position;
                float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

                Dist = Vector2.Distance(StarG1.transform.position, transform.position);
            }
            else
            {                
                Destroy(gameObject);
            }
        }

        if (StarChoice == 1) 
        {
            if (StarG2 != null)
            {

                Vector3 dir = StarG2.transform.position - transform.position;
                float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


                Dist = Vector2.Distance(StarG2.transform.position, transform.position);
            }
            else
            {               
                Destroy(gameObject);
            }
        }

        if (StarChoice == 2) 
        {
            if (StarG3 != null)
            {

                Vector3 dir = StarG3.transform.position - transform.position;
                float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

                Dist = Vector2.Distance(StarG3.transform.position, transform.position);
            }
            else
            {                
                Destroy(gameObject);
            }
        }


        

        if (Dist < 5)
        {
            ColorChange -= 1 * Time.deltaTime;
            rend.material.color = new Color(1, 1, 1, ColorChange);

            if (ColorChange <= 0)
            {
                ColorChange = 0;
            }
        }        

        else
        {
            rend.material.color = new Color(1, 1, 1, ColorChange);
            ColorChange += 1 * Time.deltaTime;
            if (ColorChange >= 1)
            {

                ColorChange = 1;
            }
        }
    }

}