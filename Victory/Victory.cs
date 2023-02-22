using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Victory : MonoBehaviour
{    
    public GameObject VictoryFolder, VirtualStick, VStar1, VStar2, VStar3, StarCounter ;
    Animator Victoryanim;
    public float count;

    StarCount _StarCount;
    

    // Start is called before the first frame update
    void Start()
    {
        Victoryanim = gameObject.GetComponent<Animator>();
        VirtualStick.SetActive(false);
        _StarCount = StarCounter.GetComponent<StarCount>();
        
    }

    // Update is called once per frame
    void Update()
    {     
            count = count + 1 * Time.deltaTime;
            if (count > 1.4f)
            {                
                Victoryanim.SetTrigger("Vic2");
            count = 1.4f;
            }
        
        if (_StarCount.StageStarCount == 2) 
        {
            Destroy(VStar1);
        }
        if (_StarCount.StageStarCount == 1)
        {
            Destroy(VStar1);
            Destroy(VStar2);
        }
        if (_StarCount.StageStarCount == 0)
        {
            Destroy(VStar1);
            Destroy(VStar2);
            Destroy(VStar3);
        }
    }
}
