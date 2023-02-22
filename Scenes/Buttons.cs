using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class Buttons : MonoBehaviour
{

    Scene m_Scene;
    string sceneName;
    string XtractStageSelect;
    int IStageSelect = 0;
    int nextStage;
    public bool CounterAd = false;
    public int LastOpen = 0;

    GameObject starCount;
    [SerializeField] StarCount starcount;

    GameObject inObj;
    [SerializeField] InterstitialAdsButton interstitialadsbutton;

    public GameObject StagePanel, PlayButton, credits, bcredits, bnoads, config;    
        

    // Start is called before the first frame update
    void Start()
    {        
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;

        starCount = GameObject.Find("Canvas");
        starcount = starCount.GetComponent<StarCount>();

        inObj = GameObject.Find("ADSManager");
        interstitialadsbutton = inObj.GetComponent<InterstitialAdsButton>();

        if (sceneName == "Title")
        {

        }
        else
        {
            XtractStageSelect = sceneName.Substring(5, 2);
            IStageSelect = int.Parse(XtractStageSelect);
            nextStage = IStageSelect + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {        
      
    }

    public void ButtonPlay()
    {
        LastOpen = 1;
        PlayButton.SetActive(false);
        
        bcredits.SetActive(false);
        StagePanel.SetActive(true);
    }

    public void Retry()
    {
        starcount.StageStarCount = 0;
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene(sceneName);

        starcount.Salvar();
    }

    public void Exit ()
    {
       SceneManager.LoadScene("Title");
    }

    public void NextStage () 
    {
        if (IStageSelect < 9)
        {
            SceneManager.LoadScene("Stage0" + nextStage);
            CounterAd = true;


        }
        else 
        {
            SceneManager.LoadScene("Stage" + nextStage);
            CounterAd = true;
        }
    }

    public void Stage01() 
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage01");        
    }

    public void Stage02()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage02");
    }

    public void Stage03()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage03");        
    }

    public void Stage04()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage04");
    }

    public void Stage05()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage05");
    }

    public void Stage06()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage06");
    }

    public void Stage07()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage07");
    }

    public void Stage08()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage08");
    }

    public void Stage09()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage09");
    }

    public void Stage10()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage10");
    }

    public void Stage11()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage11");
    }

    public void Stage12()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage12");
    }

    public void Stage13()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage13");
    }

    public void Stage14()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage14");
    }

    public void Stage15()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage15");
    }

    public void Stage16()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage16");
    }

    public void Stage17()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage17");
    }

    public void Stage18()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage18");
    }

    public void Stage19()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage19");
    }

    public void Stage20()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage20");
    }

    public void Stage21()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage21");
    }

    public void Stage22()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage22");
    }

    public void Stage23()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage23");
    }

    public void Stage24()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage24");
    }

    public void Stage25()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage25");
    }

    public void Stage26()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage26");
    }

    public void Stage27()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage27");
    }

    public void Stage28()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage28");
    }

    public void Stage29()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage29");
    }

    public void Stage30()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage30");
    }

    public void Stage31()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage31");
    }

    public void Stage32()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage32");
    }

    public void Stage33()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage33");
    }

    public void Stage34()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage34");
    }

    public void Stage35()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage35");
    }

    public void Stage36()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();
        SceneManager.LoadScene("Stage36");
    }

    public void Stage37()
    {
        starcount.s.ADS++;
        interstitialadsbutton.ShowAd();        
        SceneManager.LoadScene("Stage37");
    }


    public void Credits() 
    {
        LastOpen = 2;
        PlayButton.SetActive(false);
        
        bcredits.SetActive(false);
        credits.SetActive(true);
    }

    public void Back() 
    {
        LastOpen = 0;
        PlayButton.SetActive(true);
        
        bcredits.SetActive(true);
        StagePanel.SetActive(false);
        credits.SetActive(false);
    }
    public void Config() 
    {
        PlayButton.SetActive(false);
        
        bcredits.SetActive(false);
        StagePanel.SetActive(false);
        credits.SetActive(false);
        config.SetActive(true);
    }

    public void BackConfig()
    {
        
        PlayButton.SetActive(false);

        if (LastOpen == 0)
        {
            PlayButton.SetActive(true);
            
            bcredits.SetActive(true);
            StagePanel.SetActive(false);
            credits.SetActive(false);
        }

        if (LastOpen == 1) 
        {
            PlayButton.SetActive(false);
            
            bcredits.SetActive(false);
            StagePanel.SetActive(true);
            credits.SetActive(false);
        }
        if (LastOpen == 2)
        {
            PlayButton.SetActive(false);
           
            bcredits.SetActive(false);
            StagePanel.SetActive(false);
            credits.SetActive(true);
        }
       

        config.SetActive(false);
    }
}
