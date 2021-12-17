using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave2 : MonoBehaviour
{
    public List<GameObject> wave2 = new List<GameObject>();
    public List<GameObject> wave2Pos = new List<GameObject>();
    public List<GameObject> wave2UpDown = new List<GameObject>();
    public GameObject UpDownPos;
    public List<GameObject> wave2DownUp = new List<GameObject>();
    public GameObject DownUpPos;
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
        if(wave2.Count == 0)
        {
            print("sizeeee 00");
            //Script next = GameObject.Find("");
            //this.GetComponent<ControlShipsW3>().enabled = true;
            this.GetComponent<Wave2>().enabled = false;
            this.GetComponent<Wave3>().enabled = true;
        }
        else
        {
            for(int i = 0;i < wave2.Count;i++)
            {
                if(wave2[i]!= null)
                {
                    wave2[i].transform.position = Vector2.MoveTowards(wave2[i].transform.position,wave2Pos[i].transform.position ,speed * Time.deltaTime);
                    
                }
                if(wave2[i] == null)//.GetComponent<Enemy>().canDestroy
                {
                    print("can remove");
                    wave2.Remove(wave2[i]);
                    wave2Pos.Remove(wave2Pos[i]);
                }
            }
            
            
        }
        for(int i = 0;i < wave2UpDown.Count;i++)
        {
            if(wave2UpDown[i]!= null)
            {
                wave2UpDown[i].transform.position = Vector2.MoveTowards(wave2UpDown[i].transform.position,UpDownPos.transform.position ,speed * Time.deltaTime);
                
            }
            if(wave2UpDown[i] == null)//.GetComponent<Enemy>().canDestroy
            {
                print("can remove");
                wave2UpDown.Remove(wave2UpDown[i]);
            }
        }
        for(int i = 0;i < wave2DownUp.Count;i++)
        {
            if(wave2DownUp[i]!= null)
            {
                wave2DownUp[i].transform.position = Vector2.MoveTowards(wave2DownUp[i].transform.position,DownUpPos.transform.position ,speed * Time.deltaTime);
                
            }
            if(wave2DownUp[i] == null)//.GetComponent<Enemy>().canDestroy
            {
                print("can remove");
                wave2DownUp.Remove(wave2DownUp[i]);
            }
        }

        
    }
}
