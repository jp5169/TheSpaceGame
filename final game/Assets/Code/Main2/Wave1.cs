using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave1 : MonoBehaviour
{
    public List<GameObject> wave1 = new List<GameObject>();
    public List<GameObject> wave1Pos = new List<GameObject>();
    public float speed = 10f;
    float timer = 3f;
    void Start()
    {
        PublicVars.beginningWave = true;
        this.GetComponent<DeployChaseEnemy>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>0)
        {
            timer-=Time.deltaTime;
            //print("timer"+Time.time);
            //print("Time.deltaTime"+Time.deltaTime);
            //print("firing"+PublicVars.firing+PublicVars.beginningWave);
            
            print("timer after"+timer);
        }
        else
        {
            PublicVars.beginningWave = false;
            this.GetComponent<DeployChaseEnemy>().enabled = true;
            //print("firing"+PublicVars.firing+PublicVars.beginningWave);
        }
        if(wave1.Count == 0)
        {
            print("sizeeee 00");
            //Script next = GameObject.Find("");
            //this.GetComponent<ControlShipsW3>().enabled = true;
            this.GetComponent<Wave1>().enabled = false;
            this.GetComponent<Wave2>().enabled = true;
        }
        else
        {
            for(int i = 0;i < wave1.Count;i++)
            {
                if(wave1[i]!= null)
                {
                    wave1[i].transform.position = Vector2.MoveTowards(wave1[i].transform.position,wave1Pos[i].transform.position ,speed * Time.deltaTime);
                    
                }
                if(wave1[i] == null)//.GetComponent<Enemy>().canDestroy
                {
                    print("can remove");
                    wave1.Remove(wave1[i]);
                    wave1Pos.Remove(wave1Pos[i]);
                }
            }
            
            
        }
        
    }
}
