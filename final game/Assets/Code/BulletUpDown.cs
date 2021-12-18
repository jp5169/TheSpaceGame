using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletUpDown : MonoBehaviour
{
    public float speed;
    //private Transform player;
    private Vector2 target;
    public Transform[] goTo;
    int randNum;
    //public GameObject playerGO;
    //public Text engine;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").transform;
        randNum = Random.Range(0,6);
        //print(randNum);
        target = new Vector2(goTo[randNum].position.x,goTo[randNum].position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,target,speed * Time.deltaTime);
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroy(this.gameObject);
        }
        //make a box collider
        /*
        transform.position = Vector2.MoveTowards(transform.position,target,speed * Time.deltaTime);
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            if(this.gameObject != null)
            {
                Destroy(this.gameObject);
            }
            
        }
        */

    }
}
