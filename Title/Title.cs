using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class Title : MonoBehaviour
{   
    GameObject[] Stars;

    [SerializeField] StarCount starcount;

    public GameObject ObjScoreCounter;
    StarCount ScoreCounter;

   
   

    void Start()  
    {

        ObjScoreCounter = GameObject.Find("Canvas");
        ScoreCounter = ObjScoreCounter.GetComponent<StarCount>();
        Stars = GameObject.FindGameObjectsWithTag("TitleStars");

         if (ScoreCounter.s.Stage01Score == 0)
         {
             Stars[0].SetActive(false);
             Stars[1].SetActive(false);
             Stars[2].SetActive(false);
         }
         else if (ScoreCounter.s.Stage01Score == 1)
         {            
             Stars[1].SetActive(false);
             Stars[2].SetActive(false);
         }
         else if (ScoreCounter.s.Stage01Score == 2)    
         {            
             Stars[2].SetActive(false);
         }
         
         if (ScoreCounter.s.Stage02Score == 0)
         {
             Stars[3].SetActive(false);
             Stars[4].SetActive(false);
             Stars[5].SetActive(false);
         }
         else if (ScoreCounter.s.Stage02Score == 1)
         {
             Stars[4].SetActive(false);
             Stars[5].SetActive(false);
         }
         else if (ScoreCounter.s.Stage02Score == 2)
         {
             Stars[5].SetActive(false);
         }
         if (ScoreCounter.s.Stage03Score == 0)
         {
             Stars[6].SetActive(false);
             Stars[7].SetActive(false);
             Stars[8].SetActive(false);
         }
         else if (ScoreCounter.s.Stage03Score == 1)
         {
             Stars[7].SetActive(false);
             Stars[8].SetActive(false);
         }
         else if (ScoreCounter.s.Stage03Score == 2)
         {
             Stars[8].SetActive(false);
         }
         if (ScoreCounter.s.Stage04Score == 0)
         {
             Stars[9].SetActive(false);
             Stars[10].SetActive(false);
             Stars[11].SetActive(false);
         }
         else if (ScoreCounter.s.Stage04Score == 1)
         {
             Stars[10].SetActive(false);
             Stars[11].SetActive(false);
         }
         else if (ScoreCounter.s.Stage04Score == 2)
         {
             Stars[11].SetActive(false);
         }
         if (ScoreCounter.s.Stage05Score == 0)
         {
             Stars[12].SetActive(false);
             Stars[13].SetActive(false);
             Stars[14].SetActive(false);
         }
         else if (ScoreCounter.s.Stage05Score == 1)
         {
             Stars[13].SetActive(false);
             Stars[14].SetActive(false);
         }
         else if (ScoreCounter.s.Stage05Score == 2)
         {
             Stars[14].SetActive(false);
         }
         if (ScoreCounter.s.Stage06Score == 0)
         {
             Stars[15].SetActive(false);
             Stars[16].SetActive(false);
             Stars[17].SetActive(false);
         }
         else if (ScoreCounter.s.Stage06Score == 1)
         {
             Stars[16].SetActive(false);
             Stars[17].SetActive(false);
         }
         else if (ScoreCounter.s.Stage06Score == 2)
         {
             Stars[17].SetActive(false);
         }
         if (ScoreCounter.s.Stage07Score == 0)
         {
             Stars[18].SetActive(false);
             Stars[19].SetActive(false);
             Stars[20].SetActive(false);
         }
         else if (ScoreCounter.s.Stage07Score == 1)
         {
             Stars[19].SetActive(false);
             Stars[20].SetActive(false);
         }
         else if (ScoreCounter.s.Stage07Score == 2)
         {
             Stars[20].SetActive(false);
         }
         if (ScoreCounter.s.Stage08Score == 0)
         {
             Stars[21].SetActive(false);
             Stars[22].SetActive(false);
             Stars[23].SetActive(false);
         }
         else if (ScoreCounter.s.Stage08Score == 1)
         {
             Stars[22].SetActive(false);
             Stars[23].SetActive(false);
         }
         else if (ScoreCounter.s.Stage08Score == 2)
         {
             Stars[23].SetActive(false);
         }
         if (ScoreCounter.s.Stage09Score == 0)
         {
             Stars[24].SetActive(false);
             Stars[25].SetActive(false);
             Stars[26].SetActive(false);
         }
         else if (ScoreCounter.s.Stage09Score == 1)
         {
             Stars[25].SetActive(false);
             Stars[26].SetActive(false);
         }
         else if (ScoreCounter.s.Stage09Score == 2)
         {
             Stars[26].SetActive(false);
         }
         if (ScoreCounter.s.Stage10Score == 0)
         {
             Stars[27].SetActive(false);
             Stars[28].SetActive(false);
             Stars[29].SetActive(false);
         }
         else if (ScoreCounter.s.Stage10Score == 1)
         {
             Stars[28].SetActive(false);
             Stars[29].SetActive(false);
         }
         else if (ScoreCounter.s.Stage10Score == 2)
         {
             Stars[29].SetActive(false);
         }
         if (ScoreCounter.s.Stage11Score == 0)
         {
             Stars[30].SetActive(false);
             Stars[31].SetActive(false);
             Stars[32].SetActive(false);
         }
         else if (ScoreCounter.s.Stage11Score == 1)
         {
             Stars[31].SetActive(false);
             Stars[32].SetActive(false);
         }
         else if (ScoreCounter.s.Stage11Score == 2)
         {
             Stars[32].SetActive(false);
         }
         if (ScoreCounter.s.Stage12Score == 0)
         {
             Stars[33].SetActive(false);
             Stars[34].SetActive(false);
             Stars[35].SetActive(false);
         }
         else if (ScoreCounter.s.Stage12Score == 1)
         {
             Stars[34].SetActive(false);
             Stars[35].SetActive(false);
         }
         else if (ScoreCounter.s.Stage12Score == 2)
         {
             Stars[35].SetActive(false);
         }
         if (ScoreCounter.s.Stage13Score == 0)
         {
             Stars[36].SetActive(false);
             Stars[37].SetActive(false);
             Stars[38].SetActive(false);
         }
         else if (ScoreCounter.s.Stage13Score == 1)
         {
             Stars[37].SetActive(false);
             Stars[38].SetActive(false);
         }
         else if (ScoreCounter.s.Stage13Score == 2)
         {
             Stars[38].SetActive(false);
         }

         if (ScoreCounter.s.Stage14Score == 0)
         {
             Stars[39].SetActive(false);
             Stars[40].SetActive(false);
             Stars[41].SetActive(false);
         }
         else if (ScoreCounter.s.Stage14Score == 1)
         {
             Stars[40].SetActive(false);
             Stars[41].SetActive(false);
         }
         else if (ScoreCounter.s.Stage14Score == 2)
         {
             Stars[41].SetActive(false);
         }

         if (ScoreCounter.s.Stage15Score == 0)
         {
             Stars[42].SetActive(false);
             Stars[43].SetActive(false);
             Stars[44].SetActive(false);
         }
         else if (ScoreCounter.s.Stage15Score == 1)
         {
             Stars[43].SetActive(false);
             Stars[44].SetActive(false);
         }
         else if (ScoreCounter.s.Stage15Score == 2)
         {
             Stars[44].SetActive(false);
         }

         if (ScoreCounter.s.Stage16Score == 0)
         {
             Stars[45].SetActive(false);
             Stars[46].SetActive(false);
             Stars[47].SetActive(false);
         }
         else if (ScoreCounter.s.Stage16Score == 1)
         {
             Stars[46].SetActive(false);
             Stars[47].SetActive(false);
         }
         else if (ScoreCounter.s.Stage16Score == 2)
         {
             Stars[47].SetActive(false);
         }

         if (ScoreCounter.s.Stage17Score == 0)
         {
             Stars[48].SetActive(false);
             Stars[49].SetActive(false);
             Stars[50].SetActive(false);
         }
         else if (ScoreCounter.s.Stage17Score == 1)
         {
             Stars[49].SetActive(false);
             Stars[50].SetActive(false);
         }
         else if (ScoreCounter.s.Stage17Score == 2)
         {
             Stars[50].SetActive(false);
         }
         if (ScoreCounter.s.Stage18Score == 0)
         {
             Stars[51].SetActive(false);
             Stars[52].SetActive(false);
             Stars[53].SetActive(false);
         }
         else if (ScoreCounter.s.Stage18Score == 1)
         {
             Stars[52].SetActive(false);
             Stars[53].SetActive(false);
         }
         else if (ScoreCounter.s.Stage18Score == 2)
         {
             Stars[53].SetActive(false);
         }

         if (ScoreCounter.s.Stage19Score == 0)
         {
             Stars[54].SetActive(false);
             Stars[55].SetActive(false);
             Stars[56].SetActive(false);
         }
         else if (ScoreCounter.s.Stage19Score == 1)
         {
             Stars[55].SetActive(false);
             Stars[56].SetActive(false);
         }
         else if (ScoreCounter.s.Stage19Score == 2)
         {
             Stars[56].SetActive(false);
         }
         if (ScoreCounter.s.Stage20Score == 0)
         {
             Stars[57].SetActive(false);
             Stars[58].SetActive(false);
             Stars[59].SetActive(false);
         }
         else if (ScoreCounter.s.Stage20Score == 1)
         {
             Stars[58].SetActive(false);
             Stars[59].SetActive(false);
         }
         else if (ScoreCounter.s.Stage20Score == 2)
         {
             Stars[59].SetActive(false);
         }

         if (ScoreCounter.s.Stage21Score == 0)
         {
             Stars[60].SetActive(false);
             Stars[61].SetActive(false);
             Stars[62].SetActive(false);
         }
         else if (ScoreCounter.s.Stage21Score == 1)
         {
             Stars[61].SetActive(false);
             Stars[62].SetActive(false);
         }
         else if (ScoreCounter.s.Stage21Score == 2)
         {
             Stars[62].SetActive(false);
         }
         if (ScoreCounter.s.Stage22Score == 0)
         {
             Stars[63].SetActive(false);
             Stars[64].SetActive(false);
             Stars[65].SetActive(false);
         }
         else if (ScoreCounter.s.Stage22Score == 1)
         {
             Stars[64].SetActive(false);
             Stars[65].SetActive(false);
         }
         else if (ScoreCounter.s.Stage22Score == 2)
         {
             Stars[65].SetActive(false);
         }
         if (ScoreCounter.s.Stage23Score == 0)
         {
             Stars[66].SetActive(false);
             Stars[67].SetActive(false);
             Stars[68].SetActive(false);
         }
         else if (ScoreCounter.s.Stage23Score == 1)
         {
             Stars[67].SetActive(false);
             Stars[68].SetActive(false);
         }
         else if (ScoreCounter.s.Stage23Score == 2)
         {
             Stars[68].SetActive(false);
         }
         if (ScoreCounter.s.Stage24Score == 0)
         {
             Stars[69].SetActive(false);
             Stars[70].SetActive(false);
             Stars[71].SetActive(false);
         }
         else if (ScoreCounter.s.Stage24Score == 1)
         {
             Stars[70].SetActive(false);
             Stars[71].SetActive(false);
         }
         else if (ScoreCounter.s.Stage24Score == 2)
         {
             Stars[71].SetActive(false);
         }
         if (ScoreCounter.s.Stage25Score == 0)
         {
             Stars[72].SetActive(false);
             Stars[73].SetActive(false);
             Stars[74].SetActive(false);
         }
         else if (ScoreCounter.s.Stage25Score == 1)
         {
             Stars[73].SetActive(false);
             Stars[74].SetActive(false);
         }
         else if (ScoreCounter.s.Stage25Score == 2)
         {
             Stars[74].SetActive(false);
         }
         if (ScoreCounter.s.Stage26Score == 0)
         {
             Stars[75].SetActive(false);
             Stars[76].SetActive(false);
             Stars[77].SetActive(false);
         }
         else if (ScoreCounter.s.Stage26Score == 1)
         {
             Stars[76].SetActive(false);
             Stars[77].SetActive(false);
         }
         else if (ScoreCounter.s.Stage26Score == 2)
         {
             Stars[77].SetActive(false);
         }
         if (ScoreCounter.s.Stage27Score == 0)
         {
             Stars[78].SetActive(false);
             Stars[79].SetActive(false);
             Stars[80].SetActive(false);
         }
         else if (ScoreCounter.s.Stage27Score == 1)
         {
             Stars[79].SetActive(false);
             Stars[80].SetActive(false);
         }
         else if (ScoreCounter.s.Stage27Score == 2)
         {
             Stars[80].SetActive(false);
         }
         if (ScoreCounter.s.Stage28Score == 0)
         {
             Stars[81].SetActive(false);
             Stars[82].SetActive(false);
             Stars[83].SetActive(false);
         }
         else if (ScoreCounter.s.Stage28Score == 1)
         {
             Stars[82].SetActive(false);
             Stars[83].SetActive(false);
         }
         else if (ScoreCounter.s.Stage28Score == 2)
         {
             Stars[83].SetActive(false);
         }
         if (ScoreCounter.s.Stage29Score == 0)
         {
             Stars[84].SetActive(false);
             Stars[85].SetActive(false);
             Stars[86].SetActive(false);
         }
         else if (ScoreCounter.s.Stage29Score == 1)
         {
             Stars[85].SetActive(false);
             Stars[86].SetActive(false);
         }
         else if (ScoreCounter.s.Stage29Score == 2)
         {
             Stars[86].SetActive(false);
         }
         if (ScoreCounter.s.Stage30Score == 0)
         {
             Stars[87].SetActive(false);
             Stars[88].SetActive(false);
             Stars[89].SetActive(false);
         }
         else if (ScoreCounter.s.Stage30Score == 1)
         {
             Stars[88].SetActive(false);
             Stars[89].SetActive(false);
         }
         else if (ScoreCounter.s.Stage30Score == 2)
         {
             Stars[89].SetActive(false);
         }
         if (ScoreCounter.s.Stage31Score == 0)
         {
             Stars[90].SetActive(false);
             Stars[91].SetActive(false);
             Stars[92].SetActive(false);
         }
         else if (ScoreCounter.s.Stage31Score == 1)
         {
             Stars[91].SetActive(false);
             Stars[92].SetActive(false);
         }
         else if (ScoreCounter.s.Stage31Score == 2)
         {
             Stars[92].SetActive(false);
         }
         if (ScoreCounter.s.Stage32Score == 0)
         {
             Stars[93].SetActive(false);
             Stars[94].SetActive(false);
             Stars[95].SetActive(false);
         }
         else if (ScoreCounter.s.Stage32Score == 1)
         {
             Stars[94].SetActive(false);
             Stars[95].SetActive(false);
         }
         else if (ScoreCounter.s.Stage32Score == 2)
         {
             Stars[95].SetActive(false);
         }
         if (ScoreCounter.s.Stage33Score == 0)
         {
             Stars[96].SetActive(false);
             Stars[97].SetActive(false);
             Stars[98].SetActive(false);
         }
         else if (ScoreCounter.s.Stage33Score == 1)
         {
             Stars[97].SetActive(false);
             Stars[98].SetActive(false);
         }
         else if (ScoreCounter.s.Stage33Score == 2)
         {
             Stars[98].SetActive(false);
         }
         if (ScoreCounter.s.Stage34Score == 0)
         {
             Stars[99].SetActive(false);
             Stars[100].SetActive(false);
             Stars[101].SetActive(false);
         }
         else if (ScoreCounter.s.Stage34Score == 1)
         {
             Stars[100].SetActive(false);
             Stars[101].SetActive(false);
         }
         else if (ScoreCounter.s.Stage34Score == 2)
         {
             Stars[101].SetActive(false);
         }
         if (ScoreCounter.s.Stage35Score == 0)
         {
             Stars[102].SetActive(false);
             Stars[103].SetActive(false);
             Stars[104].SetActive(false);
         }
         else if (ScoreCounter.s.Stage35Score == 1)
         {
             Stars[103].SetActive(false);
             Stars[104].SetActive(false);
         }
         else if (ScoreCounter.s.Stage35Score == 2)
         {
             Stars[104].SetActive(false);
         }
         if (ScoreCounter.s.Stage36Score == 0)
         {
             Stars[105].SetActive(false);
             Stars[106].SetActive(false);
             Stars[107].SetActive(false);
         }
         else if (ScoreCounter.s.Stage36Score == 1)
         {
             Stars[106].SetActive(false);
             Stars[107].SetActive(false);
         }
         else if (ScoreCounter.s.Stage36Score == 2)
         {
             Stars[107].SetActive(false);
         }
         if (ScoreCounter.s.Stage37Score == 0)
         {
             Stars[108].SetActive(false);
             Stars[109].SetActive(false);
             Stars[110].SetActive(false);
         }
         else if (ScoreCounter.s.Stage37Score == 1)
         {
             Stars[109].SetActive(false);
             Stars[110].SetActive(false);
         }
         else if (ScoreCounter.s.Stage37Score == 2)
         {
             Stars[110].SetActive(false);
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void _Stage01 () 
    {
        SceneManager.LoadScene("Stage01");
    }

    public void _Stage02()
    {
        SceneManager.LoadScene("Stage02");
    }

    public void _Stage03()
    {
        SceneManager.LoadScene("Stage03");
    }

    public void _Stage04()
    {
        SceneManager.LoadScene("Stage04");
    }

    public void _Stage05()
    {
        SceneManager.LoadScene("Stage05");
    }

    public void _Stage06()
    {
        SceneManager.LoadScene("Stage06");
    }
    public void _Stage07()
    {
        SceneManager.LoadScene("Stage07");
    }
    public void _Stage08()
    {
        SceneManager.LoadScene("Stage08");

    }
    public void _Stage09()
    {
        SceneManager.LoadScene("Stage09");
    }
    public void _Stage10()
    {
        SceneManager.LoadScene("Stage10");        
    }
    public void _Stage11()
    {
        SceneManager.LoadScene("Stage11");
    }
    public void _Stage12()
    {
        SceneManager.LoadScene("Stage12");
    }
    public void _Stage13()
    {
        SceneManager.LoadScene("Stage13");
    }
    public void _Stage14()
    {
        SceneManager.LoadScene("Stage14");
    }
    public void _Stage15()
    {
        SceneManager.LoadScene("Stage15");
    }
    public void _Stage16()
    {
        SceneManager.LoadScene("Stage16");
    }
    public void _Stage17()
    {
        SceneManager.LoadScene("Stage17");
    }
    public void _Stage18()
    {
        SceneManager.LoadScene("Stage18");
    }
    public void _Stage19()
    {
        SceneManager.LoadScene("Stage19");
    }
    public void _Stage20()
    {
        SceneManager.LoadScene("Stage20");
    }
    public void _Stage21()
    {
        SceneManager.LoadScene("Stage21");
    }
    public void _Stage22()
    {
        SceneManager.LoadScene("Stage22");
    }
    public void _Stage23()
    {
        SceneManager.LoadScene("Stage23");
    }
    public void _Stage24()
    {
        SceneManager.LoadScene("Stage24");
    }
    public void _Stage25()
    {
        SceneManager.LoadScene("Stage25");
    }
    public void _Stage26()
    {
        SceneManager.LoadScene("Stage26");
    }
    public void _Stage27()
    {
        SceneManager.LoadScene("Stage27");
    }
    public void _Stage28()
    {
        SceneManager.LoadScene("Stage28");
    }
    public void _Stage29()
    {
        SceneManager.LoadScene("Stage29");
    }
    public void _Stage30()
    {
        SceneManager.LoadScene("Stage30");
    }
    public void _Stage31()
    {
        SceneManager.LoadScene("Stage31");
    }
    public void _Stage32()
    {
        SceneManager.LoadScene("Stage32");
    }
    public void _Stage33()
    {
        SceneManager.LoadScene("Stage33");
    }
    public void _Stage34()
    {
        SceneManager.LoadScene("Stage34");
    }
    public void _Stage35()
    {
        SceneManager.LoadScene("Stage35");
    }
    public void _Stage36()
    {
        SceneManager.LoadScene("Stage36");
    }
    public void _Stage37()
    {
        SceneManager.LoadScene("Stage37");
    }
}
