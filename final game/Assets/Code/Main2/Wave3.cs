using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wave3 : MonoBehaviour
{
    public List<GameObject> wave3 = new List<GameObject>();
    public List<GameObject> wave3Pos = new List<GameObject>();
    public List<GameObject> wave3Down = new List<GameObject>();
    public List<GameObject> wave3PosDown = new List<GameObject>();
    public float speed = 5f;
    float waitTime = 5f;
    //have variables for the current and next position using modules
    int moveTo = 0;
    int moveToDown = 0;
    float timer = 3f;
    void Start()
    {
        //StartCoroutine(deployShip());
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
        if(wave3.Count == 0)
        {
            if(wave3Down.Count == 0)
            {
                SceneManager.LoadScene("ControlPanel2");
            }
            else
            {
                for(int i = 0;i < wave3Down.Count;i++)
                {
                    if(wave3Down[i]!= null)
                    {
                        if(wave3Down[i].transform.position.x == wave3PosDown[moveToDown].transform.position.x && wave3Down[i].transform.position.y == wave3PosDown[moveToDown].transform.position.y)
                        {
                            //StartCoroutine(waitShip());
                            moveToDown++;
                            moveToDown %= wave3PosDown.Count;
                            //print();
                            //StopCoroutine(waitShip());

                        }
                        else
                        {
                            wave3Down[i].transform.position = Vector2.MoveTowards(wave3Down[i].transform.position,wave3PosDown[moveToDown].transform.position ,speed * Time.deltaTime);
                        }
                        
                        //StartCoroutine((waitShip(i)));
                        
                        //StopCoroutine((waitShip(i)));
                    }
                    if(wave3Down[i] == null)//.GetComponent<Enemy>().canDestroy
                    {
                        print("can remove");
                        wave3Down.Remove(wave3Down[i]);
                        //wave3Pos.Remove(wave3Pos[i]);
                    }
                }
            }
            print("sizeeee 00");
            //Script next = GameObject.Find("");
            //this.GetComponent<ControlShipsW3>().enabled = true;
            //this.GetComponent<ControlShipsW3>().enabled = false;
            //SceneManager.LoadScene("");
        }
        else if(wave3Down.Count == 0)
        {
            if(wave3.Count == 0)
            {
                SceneManager.LoadScene("ControlPanel2");
            }
            else
            {
                for(int i = 0;i < wave3.Count;i++)
                {
                    if(wave3[i]!= null)
                    {
                        if(wave3[i].transform.position.x == wave3Pos[moveTo].transform.position.x && wave3[i].transform.position.y == wave3Pos[moveTo].transform.position.y)
                        {
                            //StartCoroutine(waitShip());
                            moveTo++;
                            moveTo %= wave3Pos.Count;
                            //print();
                            //StopCoroutine(waitShip());

                        }
                        else
                        {
                            wave3[i].transform.position = Vector2.MoveTowards(wave3[i].transform.position,wave3Pos[moveTo].transform.position ,speed * Time.deltaTime);
                        }
                        
                        //StartCoroutine((waitShip(i)));
                        
                        //StopCoroutine((waitShip(i)));
                    }
                    if(wave3[i] == null)//.GetComponent<Enemy>().canDestroy
                    {
                        print("can remove");
                        wave3.Remove(wave3[i]);
                        //wave3Pos.Remove(wave3Pos[i]);
                    }
                }
            }
        }
        else
        {

            for(int i = 0;i < wave3Down.Count;i++)
            {
                if(wave3Down[i]!= null)
                {
                    if(wave3Down[i].transform.position.x == wave3PosDown[moveToDown].transform.position.x && wave3Down[i].transform.position.y == wave3PosDown[moveToDown].transform.position.y)
                    {
                        //StartCoroutine(waitShip());
                        moveToDown++;
                        moveToDown %= wave3PosDown.Count;
                        //print();
                        //StopCoroutine(waitShip());

                    }
                    else
                    {
                        wave3Down[i].transform.position = Vector2.MoveTowards(wave3Down[i].transform.position,wave3PosDown[moveToDown].transform.position ,speed * Time.deltaTime);
                    }
                    
                    //StartCoroutine((waitShip(i)));
                    
                    //StopCoroutine((waitShip(i)));
                }
                if(wave3Down[i] == null)//.GetComponent<Enemy>().canDestroy
                {
                    print("can remove");
                    wave3Down.Remove(wave3Down[i]);
                    //wave3Pos.Remove(wave3Pos[i]);
                }
            }
            for(int i = 0;i < wave3.Count;i++)
            {
                if(wave3[i]!= null)
                {
                    if(wave3[i].transform.position.x == wave3Pos[moveTo].transform.position.x && wave3[i].transform.position.y == wave3Pos[moveTo].transform.position.y)
                    {
                        //StartCoroutine(waitShip());
                        moveTo++;
                        moveTo %= wave3Pos.Count;
                        //print();
                        //StopCoroutine(waitShip());

                    }
                    else
                    {
                        wave3[i].transform.position = Vector2.MoveTowards(wave3[i].transform.position,wave3Pos[moveTo].transform.position ,speed * Time.deltaTime);
                    }
                    
                    //StartCoroutine((waitShip(i)));
                    
                    //StopCoroutine((waitShip(i)));
                }
                if(wave3[i] == null)//.GetComponent<Enemy>().canDestroy
                {
                    print("can remove");
                    wave3.Remove(wave3[i]);
                    //wave3Pos.Remove(wave3Pos[i]);
                }
            }
            
        
            
            
        }

        
    }
    /*
    IEnumerator waitShip()
    {
        print("in coroutine");
        while(true)
        {
            yield return new WaitForSeconds(waitTime);
        }
        
    }
    */
    /*
    IEnumerator deployShip()
    {
        for(int i = 0;i < wave3.Count;i++)
        {
            if(wave3[i]!= null)
            {
                if(wave3[i].transform.position.x == wave3Pos[moveTo].transform.position.x && wave3[i].transform.position.y == wave3Pos[moveTo].transform.position.y)
                {
                    
                    moveTo++;
                    moveTo %= wave3Pos.Count;
                    //print();
                    //StopCoroutine(waitShip());
                    yield return new WaitForSeconds(20f);
                }
                else
                {
                    wave3[i].transform.position = Vector2.MoveTowards(wave3[i].transform.position,wave3Pos[moveTo].transform.position ,speed * Time.deltaTime);
                }
                
                //StartCoroutine((waitShip(i)));
                
                //StopCoroutine((waitShip(i)));
            }
            if(wave3[i] == null)//.GetComponent<Enemy>().canDestroy
            {
                print("can remove");
                wave3.Remove(wave3[i]);
                //wave3Pos.Remove(wave3Pos[i]);
            }
        }
    }
    */
    
}
