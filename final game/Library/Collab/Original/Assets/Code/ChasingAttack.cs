using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChasingAttack : MonoBehaviour
{   
    //public GameObject loc;
    public float speed;
    //public Text lowerBooster;

    public GameObject explosion;

    private int randNum; 

    public Transform[] BackParts;

    public Text[] BackPArtsText;

    void Start()
    {
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
            PublicVars.boosterLowHealth -= 20f;
            //print(PublicVars.boosterLowHealth);
            BackPArtsText[randNum].text = PublicVars.boosterLowHealth.ToString();
            Instantiate(explosion, BackParts[randNum].transform.position, Quaternion.identity);
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
}
