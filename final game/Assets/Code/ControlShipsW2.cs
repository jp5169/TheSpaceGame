using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlShipsW2 : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> wave2 = new List<GameObject>();
    public List<GameObject> wave2Pos = new List<GameObject>();
    public float speed = 10f;
    float timer = 2.5f;
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
        if(wave2.Count == 0)
        {
            print("sizeeee 00");
            //Script next = GameObject.Find("");
            //this.GetComponent<ControlShipsW3>().enabled = true;
            this.GetComponent<ControlShipsW2>().enabled = false;
            this.GetComponent<ControlShipsW3>().enabled = true;
            this.GetComponent<DeployChaseEnemy>().enabled = false;
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
        
    }
}
