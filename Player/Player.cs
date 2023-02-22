using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //UI
    public float fuel = 100;
    public Image Fuel;
    public int FuelWast = 20;
    //

    //Victory
    public GameObject VictoryFolder;
    Victory _victory;
    //

    //ParticleSystem
    public ParticleSystem Particle;
    public GameObject Explosion;


    public GameObject _FrontCollider;
    FrontCollider frontCollider;

    public bool LandOnObjective = false;

    public Renderer Rend;

    Rigidbody2D rb;

    public float BTiltX = 0;
    public float TiltX = 0;
    public int Thrust = 50;
    
    public bool Grounded = false;

    public bool Dead = false;    
    public bool Victory = false;
    float CTime = 0;
    bool OnlyOneTime = false;

    Scene currentScene;
    string SceneName;

    public Vector3 CheckPointPos;
    public GameObject Star, Star1, Star2;
    public bool RestartCamPos = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        frontCollider = _FrontCollider.GetComponent<FrontCollider>();        
        Rend = GetComponent<Renderer>();
        _victory = VictoryFolder.GetComponent<Victory>();

        currentScene = SceneManager.GetActiveScene();

        SceneName = currentScene.name;

        if (SceneName == "Stage25" || SceneName == "Stage30" || SceneName == "Stage31" || SceneName == "Stage33" || SceneName == "Stage34" || SceneName == "Stage35" || SceneName == "Stage36" || SceneName == "Stage37") 
        {
            fuel = 1000000000;
        }
        

    }

    void Update()
    {
        Fuel.fillAmount = fuel / 100;        
        
    }

    void FixedUpdate()
    {
        if (Dead == false && Victory == false)
        {
            rb.AddForce(transform.up * Thrust);
            fuel -= FuelWast * Time.deltaTime;

            //
            TiltX += BTiltX * Time.deltaTime;
            if(TiltX > 20)
            {
                TiltX = 20;
            }

            if (TiltX < -20)
            {
                TiltX = -20;
            }

            if (BTiltX == 0) 
            {
                if (TiltX > 0 && Grounded == false)

                    TiltX -= 20 * Time.deltaTime;


                else if (TiltX < 0 && Grounded == false)
                {

                    TiltX += 20 * Time.deltaTime;
                }
            }
            //           


            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, TiltX);


            if (frontCollider.Collision == true)
            {

                Dead = true;
            }

            if (Grounded == true || LandOnObjective == true)
            {
                rb.velocity = new Vector2(0, 0);
                rb.gravityScale = 0;
                rb.angularVelocity = 0;
            }

            else 
            {
                rb.gravityScale = 0.5f;
            }

            if (LandOnObjective == true)
            {
                
                CTime = CTime + 1 * Time.deltaTime;                 
                

                if (CTime > 1)
                {                    
                    Victory = true;
                    CTime = 1;
                }
            }

            if (Victory == true) 
            {
                VictoryFolder.SetActive(true);
            }
        }

        else
        {
            rb.velocity = new Vector2(0, 0);
            if (OnlyOneTime == false)
            {
                OnlyOneTime = true;                
                Particle.Stop();               
                Rend.enabled = false;
                Instantiate(Explosion, transform.position, transform.rotation);
            }
        }


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Grounded = true;
        }

        if (col.gameObject.tag == "Mars")
        {
            LandOnObjective = true;
           
        }

        if (col.relativeVelocity.magnitude > 4)
        {
            Dead = true;
        }

        if (col.gameObject.tag == "Death")
        {
            Dead = true;
        }
        
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "Mars")
        {
            Grounded = false;
            LandOnObjective = false;
            CTime = 0;
        }

        
    }

    public void Engine()
    {
        if (fuel > 0 && Dead == false)
        {
            Thrust = 5;
            FuelWast = 20;
            Particle.Play();           
            //Ground.SetActive(false);
            RestartCamPos = false;


        }      

    }

    public void StopEngine() 
    {
        Particle.Stop();
        Thrust = 0;
        FuelWast = 0;
    }

    public void Left()
    {
        if (Grounded == false && LandOnObjective == false)
        {
            BTiltX = 30;            
        }
    }

    public void Right() 
    {
    if (Grounded == false && LandOnObjective == false)
        {
            BTiltX = -30;           
        }
    }

    public void NoComands () 
    {
        BTiltX = 0;        
    }

    public void ADSFuel () 
    {
        fuel = 100;
    }

    public void Respawn() 
    {
        if (SceneName == "Stage25" || SceneName == "Stage30" || SceneName == "Stage31" || SceneName == "Stage33" || SceneName == "Stage34" || SceneName == "Stage35" || SceneName == "Stage36" || SceneName == "Stage37")
        {
            fuel = 1000000000;
        }
        else 
        {
            fuel = 100;
        }
        frontCollider.Collision = false;
        transform.position = CheckPointPos;
        rb.velocity = new Vector2(0, 0);
        rb.gravityScale = 0;
        rb.angularVelocity = 0;
        //Ground.SetActive(true);
        OnlyOneTime = false;
        Rend.enabled = true;
        Particle.Play();
        Dead = false;
        RestartCamPos = true;
    }
}

    

