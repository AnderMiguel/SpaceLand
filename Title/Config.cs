using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Config : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    public Slider MusicSlider;    

    void Awake() 
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {       
        m_MyAudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        m_MyAudioSource.volume = MusicSlider.value;
       
    }
}
