using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChasingAttack : MonoBehaviour
{   
    public GameObject enemyexplosion;
    public AudioClip explosionAudio; 

    AudioSource _as;
    public GameObject[] BoosterBars;
    public float speed;
    
    public GameObject explosion;

    private int randNum; 

    public Transform[] BackParts;

    //public Text[] backText;
    private float health = 20;

    void Start()
    {
        _as = GetComponent<AudioSource>();
        randNum = Random.Range(0, 2);
        print("Random Number " + randNum);
    }

    // Update is called once per frame
    void Update()
    {
        //x -1.1f, y -.4f
        transform.position = Vector2.MoveTowards(transform.position,BackParts[randNum].transform.position ,speed * Time.deltaTime);
        if(transform.position.x == BackParts[randNum].transform.position.x && transform.position.y == BackParts[randNum].transform.position.y)
        {
            _as.clip = explosionAudio;
            _as.Play();
            if(randNum == 0)//boosterUP
            {
                PublicVars.boosterUpHealth -= 20f;
                BoosterBars[randNum].GetComponent<HealthBar>().SetHealth(PublicVars.boosterUpHealth);
                //backText[randNum].text = PublicVars.boosterUpHealth.ToString();
            }
            else if(randNum == 1)//boosterDown
            {
                _as.clip = explosionAudio;
                _as.Play();
                //print("taking damage booster down");
                PublicVars.boosterLowHealth -= 20f;
                BoosterBars[randNum].GetComponent<HealthBar>().SetHealth(PublicVars.boosterLowHealth);
                //backText[randNum].text = PublicVars.boosterLowHealth.ToString();

            }
            Instantiate(explosion, BackParts[randNum].transform.position, Quaternion.identity);
            //print(PublicVars.boosterLowHealth);
            
            Destroy(gameObject);
        }
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            print("hellllooo");
            PublicVars.boosterLowHealth -= 20f;
            print(PublicVars.boosterLowHealth);
            lowerBooster.text = PublicVars.boosterLowHealth.ToString();
            //Destroy(gameObject);
        }
    }
    */
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="bulletP")
        {
            print("bullet colliding with me");
            if(health<=0)
            {
                Instantiate(enemyexplosion,transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            else
            {
                health -=10f;//player bullet damage
            }
            
        }
        
    }
}
