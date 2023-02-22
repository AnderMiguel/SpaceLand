using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;


public class StarCount : MonoBehaviour
{
    public int StageStarCount = 0;   

    Scene currentScene;
    string SceneName;

    public Save s;

    public bool CanShowAD = false;


    // Start is called before the first frame update
    void Start()
    {
        s = new Save();

        Load();

        currentScene = SceneManager.GetActiveScene();

        SceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (s.ADS > 4) 
        {
            CanShowAD = true;
            if (s.ADS > 5) 
            {
                s.ADS = 0;
                Salvar();
            }
        }
        else 
        {
            CanShowAD = false;
        }
        //RESET SCORE 
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            print("RESETO GERAL");
            s.Stage01Score = 0;
            s.Stage02Score = 0;
            s.Stage03Score = 0;
            s.Stage04Score = 0;
            s.Stage05Score = 0;
            s.Stage06Score = 0;
            s.Stage07Score = 0;
            s.Stage08Score = 0;
            s.Stage09Score = 0;
            s.Stage10Score = 0;
            s.Stage11Score = 0;
            s.Stage12Score = 0;
            s.Stage13Score = 0;
            s.Stage14Score = 0;
            s.Stage15Score = 0;
            s.Stage16Score = 0;
            s.Stage17Score = 0;
            s.Stage18Score = 0;
            s.Stage19Score = 0;
            s.Stage20Score = 0;
            s.Stage21Score = 0;
            s.Stage22Score = 0;
            s.Stage23Score = 0;
            s.Stage24Score = 0;
            s.Stage25Score = 0;
            s.Stage26Score = 0;
            s.Stage27Score = 0;
            s.Stage28Score = 0;
            s.Stage29Score = 0;
            s.Stage30Score = 0;
            s.Stage31Score = 0;
            s.Stage32Score = 0;
            s.Stage33Score = 0;
            s.Stage34Score = 0;
            s.Stage35Score = 0;
            s.Stage36Score = 0;
            s.Stage37Score = 0;
            s.ADS = 0;
            Salvar();
            
        }

        //
        if (SceneName == "Stage01" && s.Stage01Score < StageStarCount)
        {            
            s.Stage01Score = StageStarCount;
            Salvar();
        }        

        else if (SceneName == "Stage02" && s.Stage02Score < StageStarCount)
        {
            s.Stage02Score = StageStarCount;
        }

        else if (SceneName == "Stage03" && s.Stage03Score < StageStarCount)
        {
            s.Stage03Score = StageStarCount;
        }

        else if (SceneName == "Stage04" && s.Stage04Score < StageStarCount)
        {
            s.Stage04Score = StageStarCount;
        }

        else if (SceneName == "Stage05" && s.Stage05Score < StageStarCount)
        {
            s.Stage05Score = StageStarCount;
        }
        else if (SceneName == "Stage06" && s.Stage06Score < StageStarCount)
        {
            s.Stage06Score = StageStarCount;
        }
        else if (SceneName == "Stage07" && s.Stage07Score < StageStarCount)
        {
            s.Stage07Score = StageStarCount;
        }
        else if (SceneName == "Stage08" && s.Stage08Score < StageStarCount)
        {
            s.Stage08Score = StageStarCount;
        }
        else if (SceneName == "Stage09" && s.Stage09Score < StageStarCount)
        {
            s.Stage09Score = StageStarCount;
        }
        else if (SceneName == "Stage10" && s.Stage10Score < StageStarCount)
        {
            s.Stage10Score = StageStarCount;
        }
        else if (SceneName == "Stage11" && s.Stage11Score < StageStarCount)
        {
            s.Stage11Score = StageStarCount;
        }
        else if (SceneName == "Stage12" && s.Stage12Score < StageStarCount)
        {
            s.Stage12Score = StageStarCount;
        }
        else if (SceneName == "Stage13" && s.Stage13Score < StageStarCount)
        {
            s.Stage13Score = StageStarCount;
        }
        else if (SceneName == "Stage14" && s.Stage14Score < StageStarCount)
        {
            s.Stage14Score = StageStarCount;
        }
        else if (SceneName == "Stage15" && s.Stage15Score < StageStarCount)
        {
            s.Stage15Score = StageStarCount;
        }
        else if (SceneName == "Stage16" && s.Stage16Score < StageStarCount)
        {
            s.Stage16Score = StageStarCount;
        }
        else if (SceneName == "Stage17" && s.Stage17Score < StageStarCount)
        {
            s.Stage17Score = StageStarCount;
        }
        else if (SceneName == "Stage18" && s.Stage18Score < StageStarCount)
        {
            s.Stage18Score = StageStarCount;
        }
        else if (SceneName == "Stage19" && s.Stage19Score < StageStarCount)
        {
            s.Stage19Score = StageStarCount;
        }
        else if (SceneName == "Stage20" && s.Stage20Score < StageStarCount)
        {
            s.Stage20Score = StageStarCount;
        }
        else if (SceneName == "Stage21" && s.Stage21Score < StageStarCount)
        {
            s.Stage21Score = StageStarCount;
        }
        else if (SceneName == "Stage22" && s.Stage22Score < StageStarCount)
        {
            s.Stage22Score = StageStarCount;
        }
        else if (SceneName == "Stage23" && s.Stage23Score < StageStarCount)
        {
            s.Stage23Score = StageStarCount;
        }
        else if (SceneName == "Stage24" && s.Stage24Score < StageStarCount)
        {
            s.Stage24Score = StageStarCount;
        }
        else if (SceneName == "Stage25" && s.Stage25Score < StageStarCount)
        {
            s.Stage25Score = StageStarCount;

        }
        else if (SceneName == "Stage26" && s.Stage26Score < StageStarCount)
        {
            s.Stage26Score = StageStarCount;
        }
        else if (SceneName == "Stage27" && s.Stage27Score < StageStarCount)
        {
            s.Stage27Score = StageStarCount;
        }
        else if (SceneName == "Stage28" && s.Stage28Score < StageStarCount)
        {
            s.Stage28Score = StageStarCount;
        }
        else if (SceneName == "Stage29" && s.Stage29Score < StageStarCount)
        {
            s.Stage29Score = StageStarCount;
        }
        else if (SceneName == "Stage30" && s.Stage30Score < StageStarCount)
        {
            s.Stage30Score = StageStarCount;
        }
        else if (SceneName == "Stage31" && s.Stage31Score < StageStarCount)
        {
            s.Stage31Score = StageStarCount;
        }
        else if (SceneName == "Stage32" && s.Stage32Score < StageStarCount)
        {
            s.Stage32Score = StageStarCount;
        }
        else if (SceneName == "Stage33" && s.Stage33Score < StageStarCount)
        {
            s.Stage33Score = StageStarCount;
        }
        else if (SceneName == "Stage34" && s.Stage34Score < StageStarCount)
        {
            s.Stage34Score = StageStarCount;
        }
        else if (SceneName == "Stage35" && s.Stage35Score < StageStarCount)
        {
            s.Stage35Score = StageStarCount;
        }
        else if (SceneName == "Stage36" && s.Stage36Score < StageStarCount)
        {
            s.Stage36Score = StageStarCount;
        }
        else if (SceneName == "Stage37" && s.Stage37Score < StageStarCount)
        {
            s.Stage37Score = StageStarCount;
        }
              
    }

    public void Salvar()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = File.Create(Application.persistentDataPath + "/StarCount.data");        

        bf.Serialize(fs, s);
        fs.Close();
    }

    void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/StarCount.data"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open(Application.persistentDataPath + "/StarCount.data", FileMode.Open);

            s = (Save)bf.Deserialize(fs);

            fs.Close();
        }
    }        


    [Serializable]
    public class Save
    {
        public int Stage01Score;
        public int Stage02Score;
        public int Stage03Score;
        public int Stage04Score = 0;
        public int Stage05Score = 0;
        public int Stage06Score = 0;
        public int Stage07Score = 0;
        public int Stage08Score = 0;
        public int Stage09Score = 0;
        public int Stage10Score = 0;
        public int Stage11Score = 0;
        public int Stage12Score = 0;
        public int Stage13Score = 0;
        public int Stage14Score = 0;
        public int Stage15Score = 0;
        public int Stage16Score = 0;
        public int Stage17Score = 0;
        public int Stage18Score = 0;
        public int Stage19Score = 0;
        public int Stage20Score = 0;
        public int Stage21Score = 0;
        public int Stage22Score = 0;
        public int Stage23Score = 0;
        public int Stage24Score = 0;
        public int Stage25Score = 0;
        public int Stage26Score = 0;
        public int Stage27Score = 0;
        public int Stage28Score = 0;
        public int Stage29Score = 0;
        public int Stage30Score = 0;
        public int Stage31Score = 0;
        public int Stage32Score = 0;
        public int Stage33Score = 0;
        public int Stage34Score = 0;
        public int Stage35Score = 0;
        public int Stage36Score = 0;
        public int Stage37Score = 0;

        public int ADS = 0;


    }
}
