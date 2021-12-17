using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    float startY;
    float startX;
    float addY;
    float addX;
    int random1;
    int random2;

    // Start is called before the first frame update
    void Start()
    {
        startY = transform.position.y;
        startX = transform.position.x;
        random1 = Random.Range(1, 4);
        random2 = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        addY = Mathf.PingPong(Time.time, random1);
        addX = Mathf.PingPong(Time.time, random2);
        transform.position = new Vector2(transform.position.x, startY + addY);
        transform.position = new Vector2(startX + addX, transform.position.y);
    }
}
