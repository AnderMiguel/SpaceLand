using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guide : MonoBehaviour
{
    public GameObject Point;
    public float Distanc;
    public float Dist;
    public GameObject MainCamera;

    float ColorChange = 1;
    Renderer rend;


    //float varY = 0;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Point.transform.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        Distanc = Vector2.Distance(Point.transform.position, transform.position);


        Dist = Vector2.Distance(Point.transform.position, transform.position);


        if (Dist < 8)
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
