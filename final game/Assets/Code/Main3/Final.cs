using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    public List<GameObject> FinalBoss = new List<GameObject>();
    public List<GameObject> FinalBossPos = new List<GameObject>();
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
        if(FinalBoss.Count == 0)
        {
            print("sizeeee 00");
            //Script next = GameObject.Find("");
            //this.GetComponent<ControlShipsW3>().enabled = true;
            //this.GetComponent<FinalBoss>().enabled = false;
            //this.GetComponent<Wave2>().enabled = true;
            SceneManager.LoadScene("Win");
        }
        else
        {
            for(int i = 0;i < FinalBoss.Count;i++)
            {
                if(FinalBoss[i]!= null)
                {
                    FinalBoss[i].transform.position = Vector2.MoveTowards(FinalBoss[i].transform.position,FinalBossPos[i].transform.position ,speed * Time.deltaTime);
                    
                }
                if(FinalBoss[i] == null)//.GetComponent<Enemy>().canDestroy
                {
                    print("can remove");
                    FinalBoss.Remove(FinalBoss[i]);
                    FinalBossPos.Remove(FinalBossPos[i]);
                }
            }
            
            
        }
        
    }
}
