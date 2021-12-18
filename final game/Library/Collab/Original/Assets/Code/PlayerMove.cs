using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Joystick joystick;
    /*
    Vector3 fingerPos;
    Vector3 dir;
    */
    float verticalMove;
    float horizontalMove;
    float speed = 10f;
    Rigidbody2D _rigidbody;
    bool firing = false;
    Vector3 initialPos;
    float startTime;
    private float lastClickTime = -1;
    private const float DOUBLE_CLICK_TIME = .2f;
    float boundryY = 3.375f;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            fingerPos = Camera.main.ScreenToWorldPoint(touch.position);
            fingerPos.z = 0;
            dir = (fingerPos - transform.position);
            rb2D.velocity = new Vector2(dir.x, dir.y) * speed;

            if(touch.phase == TouchPhase.Ended){
                rb2D.velocity = Vector2.zero;
            }
        }
        */
        verticalMove = joystick.Vertical * speed;
        horizontalMove = joystick.Horizontal * speed;
        _rigidbody.velocity = new Vector2(horizontalMove,verticalMove);
        //_rigidbody.velocity = new Vector2(_rigidbody.velocity.x,verticalMove);
        //print(verticalMove);

        /*
        below is just for hard movements
        if(joystick.Vertical > .2f)
        {
            verticalMove = speed;
        }
        else if(joystick.Vertical > .2f)
        {
            verticalMove = -speed;
        }
        else
        {
            verticalMove = 0;
        }





        */
        if(Input.GetMouseButtonDown(0))
        {
            //firstMove = true;
            //moving = true;
            initialPos = transform.position;
            //print("initialPos: " + initialPos);
            startTime = Time.time;
            //print("startTime  "+ Time.time);
            float timeSinceLastClick = Time.time - lastClickTime;
            //print("time since last clicked"+ timeSinceLastClick);
            if(timeSinceLastClick <= DOUBLE_CLICK_TIME)
            {
                print("firing");
                firing = true;
                //_audiosrc.clip = run;
                //_audiosrc.Play();
            }
            else{
                print("not firing");
                firing = false;
                //_audiosrc.clip = walk;
                //_audiosrc.Play();
            }
            /*
            RaycastHit hit;
            if(Physics.Raycast(mainCam.ScreenPointToRay(Input.mousePosition), out hit, 200)){
                navAgent.destination = hit.point;
                hitP = hit.point;
            }
            */
            lastClickTime = Time.time;
        }
        if(transform.position.y >= boundryY)
        {
            transform.position = new Vector3(transform.position.x, boundryY, 0);
        }
        else if(transform.position.y <= -boundryY)
        {
            transform.position = new Vector3(transform.position.x, -boundryY, 0);
        }
        if(transform.position.x >= -2.725f)
        {
            transform.position = new Vector3(-2.725f, transform.position.y, 0);
        }
        else if(transform.position.x <= -8.4725f)
        {
            transform.position = new Vector3(-8.4725f, transform.position.y, 0);
        }
        transform.Translate(Vector3.up * Time.deltaTime * speed * joystick.Vertical);
        transform.Translate(Vector3.right * Time.deltaTime * speed * joystick.Horizontal);
        
    }
}
