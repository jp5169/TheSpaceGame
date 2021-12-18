using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlShipsW3 : MonoBehaviour
{
    public List<GameObject> wave3 = new List<GameObject>();
    public List<GameObject> wave3Pos = new List<GameObject>();
    public float speed = 10f;
    float timer = 2f;
    //float waitTime = 5f;
    void Start()
    {
        PublicVars.beginningWave = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>0)
        {
            timer-=Time.deltaTime;
            print("timer"+Time.time);
            //print("Time.deltaTime"+Time.deltaTime);
            print("firing"+PublicVars.firing+PublicVars.beginningWave);
            
            print("timer after"+timer);
        }
        else
        {
            PublicVars.beginningWave = false;
            this.GetComponent<DeployChaseEnemy>().enabled = true;
        }
        if(wave3.Count == 0)
        {
            print("sizeeee 00");
            //Script next = GameObject.Find("");
            //this.GetComponent<ControlShipsW3>().enabled = true;
            //this.GetComponent<ControlShipsW3>().enabled = false;
            SceneManager.LoadScene("FixingShipIntro");
        }
        else
        {
            for(int i = 0;i < wave3.Count;i++)
            {
                if(wave3[i]!= null)
                {
                    wave3[i].transform.position = Vector2.MoveTowards(wave3[i].transform.position,wave3Pos[i].transform.position ,speed * Time.deltaTime);
                    //StartCoroutine((moveShip(i)));
                }
                if(wave3[i] == null)//.GetComponent<Enemy>().canDestroy
                {
                    print("can remove");
                    wave3.Remove(wave3[i]);
                    wave3Pos.Remove(wave3Pos[i]);
                }
            }
            
            
        }
        
    }
}
