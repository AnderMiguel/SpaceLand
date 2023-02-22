using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouLose : MonoBehaviour
{
    string sceneName;
    Scene currentScene;

    public GameObject _player, VirtualStick;
    Player player;

    //Buttons
    public GameObject retry;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        
        player = _player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
     if (player.Dead == true)
        {
            VirtualStick.SetActive(false);
            retry.SetActive(true);            
        }
     else 
        {
            
            VirtualStick.SetActive(true);
            retry.SetActive(false);
        }
    }

    public void Retry() 
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Exit () 
    {
    
    }
}
