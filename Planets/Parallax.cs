using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{    
    public Renderer Parallax1;
    public Renderer Parallax2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0.005f * Time.deltaTime, 0);
        Parallax1.material.mainTextureOffset += offset;
        Parallax2.material.mainTextureOffset += offset * 5;
    }
}
