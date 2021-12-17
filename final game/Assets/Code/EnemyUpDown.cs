using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUpDown : MonoBehaviour
{
    public Transform fireA;
    private float timeBetweenShots;
    public float startTimeBwtShots;
    public GameObject bullet;
    //public float health = 30f;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBetweenShots = startTimeBwtShots;
    }

    // Update is called once per frame
    void Update()
    {
        //print("timeBetweenShots outside"+ timeBetweenShots);
        if(timeBetweenShots < 0)
        {
            Instantiate(bullet, fireA.transform.position, Quaternion.identity);
            timeBetweenShots = startTimeBwtShots;
            //print("startTimeBwtShots"+ startTimeBwtShots);
        }
        else{
            timeBetweenShots -= 1;
            //print("timeBetweenShots inside"+ timeBetweenShots);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="bulletP")
        {
            /*
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
            */
            Destroy(gameObject);
            
        }
        
    }
}
