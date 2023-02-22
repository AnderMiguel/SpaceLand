using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    float count = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += 1 * Time.deltaTime;

        if (count > 0.31) 
        {
            Destroy(gameObject);
        }
    }
}
