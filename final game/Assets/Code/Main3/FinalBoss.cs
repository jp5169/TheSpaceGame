using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalBoss : MonoBehaviour
{
    public Transform fireA;
    public Transform fireB;
    public Transform fireC;
    public Transform fireD;
    private float timeBetweenShots;
    public float startTimeBwtShots;
    private float timeBetweenShotsChase;
    public float startTimeBwtShotsChase;
    public GameObject bullet;
    public GameObject chase;
    public float health = 200f;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBetweenShots = startTimeBwtShots;
        timeBetweenShotsChase = startTimeBwtShotsChase;
    }

    // Update is called once per frame
    void Update()
    {
        if(PublicVars.paused == false){

            //print("timeBetweenShots outside"+ timeBetweenShots);
            if(timeBetweenShots < 0)
            {
                Instantiate(bullet, fireA.transform.position, Quaternion.identity);
                Instantiate(bullet, fireB.transform.position, Quaternion.identity);
                timeBetweenShots = startTimeBwtShots;
                //print("startTimeBwtShots"+ startTimeBwtShots);
            }
            else{
                timeBetweenShots -= 1;
                //print("timeBetweenShots inside"+ timeBetweenShots);
            }
            if(timeBetweenShotsChase < 0)
            {
                GameObject fire = Instantiate(chase, fireC.transform.position, Quaternion.identity);
                GameObject fire2 = Instantiate(chase, fireD.transform.position, Quaternion.identity);
                fire.GetComponent<ChasingAttack>().enabled = true;
                fire2.GetComponent<ChasingAttack>().enabled = true;
                timeBetweenShotsChase = startTimeBwtShotsChase;
                //print("startTimeBwtShots"+ startTimeBwtShots);
            }
            else{
                timeBetweenShotsChase -= 1;
                //print("timeBetweenShots inside"+ timeBetweenShots);
            }
        }
            
            
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="bulletP")
        {
            //print("bullet colliding with me");
            if(health<=0)
            {
                print("currently destroying");
                //canDestroy = true;
                Destroy(gameObject);
                //remove object from list
                //canDestroy = true;
                
            }
            else
            {
                health -=10f;//player bullet damage
            }
            
        }
        
    }
}
