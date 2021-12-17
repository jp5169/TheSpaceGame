using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlShips : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> wave1 = new List<GameObject>();
    public List<GameObject> wave1Pos = new List<GameObject>();
    public float speed = 10f;
    float timer = 2f;
    void Start()
    {
        PublicVars.beginningWave = true;
        //this.GetComponent<DeployChaseEnemy>().enabled = false;
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
        //print("plzz help me");
        //print(wave1[0].transform.position);
        //print(wave1Pos[0].transform.position);
        if(wave1.Count == 0)
        {
            print("sizeeee 00");
            //Script next = GameObject.Find("");
            this.GetComponent<ControlShipsW2>().enabled = true;
            this.GetComponent<ControlShips>().enabled = false;
            this.GetComponent<DeployChaseEnemy>().enabled = false;
            //PublicVars.beginningWave = true;
        }
        else
        {
            if(wave1[0]!= null)
            {
                wave1[0].transform.position = Vector2.MoveTowards(wave1[0].transform.position,wave1Pos[0].transform.position ,speed * Time.deltaTime);
            }
            if(wave1[0] == null)//.GetComponent<Enemy>().canDestroy
            {
                print("can remove");
                wave1.Remove(wave1[0]);
            }
        }
        
    }
    
}
