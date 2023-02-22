using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroid : MonoBehaviour
{
    float RotationZ = 0;
    public float speed = 1;

    Scene currentScene;
    string SceneName;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();

        SceneName = currentScene.name;

        

        if (SceneName == "Stage34" || SceneName == "Stage35" || SceneName == "Stage36" || SceneName == "Stage37")
        {
            speed = 0;
        }
        else
        {
            speed = Random.Range(-1, 1);
        }

        
        RotationZ = RotationZ + speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()    {       
        
        transform.Rotate(0, 0, RotationZ);
    }
}
