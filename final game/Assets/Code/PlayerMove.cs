using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    /* Heath Bar*/
    public GameObject[] HealthObjects;


    /* Other Stuff */
    public Transform fireA;
    bool blasterUpFire = true;
    bool blasterDownFire = true;
    public Transform fireB;
    public Joystick joystick;
    float verticalMove;
    float horizontalMove;
    float speed = 10f;
    bool decSpeed = true;
    Rigidbody2D _rigidbody;
    //bool firing = false;
    //Vector3 initialPos;
    float startTime;
    //private float lastClickTime = -1;
    //private const float DOUBLE_CLICK_TIME = .2f;
    float boundryY = 3.375f;
    public GameObject bullet;
    public int bulletForce = 800;
    public float timebtwFire;
    // Start is called before the first frame update

    void Start()
    {

        if (SceneManager.GetActiveScene().name == "Main")
        {
            //engineBar.GetComponent<HealthBar>().SetMaxHealth(PublicVars.engineHealth);
            HealthObjects[0].GetComponent<HealthBar>().SetMaxHealth(PublicVars.engineHealth);
            HealthObjects[1].GetComponent<HealthBar>().SetMaxHealth(PublicVars.boosterUpHealth);
            HealthObjects[2].GetComponent<HealthBar>().SetMaxHealth(PublicVars.boosterLowHealth);
            HealthObjects[3].GetComponent<HealthBar>().SetMaxHealth(PublicVars.blasterUpHealth);
            HealthObjects[4].GetComponent<HealthBar>().SetMaxHealth(PublicVars.blasterLowHealth);
        }
        else if(SceneManager.GetActiveScene().name == "Main2")
        {
            HealthObjects[0].GetComponent<HealthBar>().SetHealth(PublicVars.engineHealth);
            HealthObjects[1].GetComponent<HealthBar>().SetHealth(PublicVars.boosterUpHealth);
            HealthObjects[2].GetComponent<HealthBar>().SetHealth(PublicVars.boosterLowHealth);
            HealthObjects[3].GetComponent<HealthBar>().SetHealth(PublicVars.blasterUpHealth);
            HealthObjects[4].GetComponent<HealthBar>().SetHealth(PublicVars.blasterLowHealth);
        }
        else if(SceneManager.GetActiveScene().name == "Main3")
        {
            HealthObjects[0].GetComponent<HealthBar>().SetHealth(PublicVars.engineHealth);
            HealthObjects[1].GetComponent<HealthBar>().SetHealth(PublicVars.boosterUpHealth);
            HealthObjects[2].GetComponent<HealthBar>().SetHealth(PublicVars.boosterLowHealth);
            HealthObjects[3].GetComponent<HealthBar>().SetHealth(PublicVars.blasterUpHealth);
            HealthObjects[4].GetComponent<HealthBar>().SetHealth(PublicVars.blasterLowHealth);
        }
            
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }


    /*
    public void Shoot()
    {
        /*
        if(PublicVars.firing == true)
        {
            print("not firing");
            PublicVars.firing = false;
        }
        else
        {
            print("firing");
            GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            newBullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletForce * transform.localScale.x, 0));
            PublicVars.firing = true;
        }
        
        print("firing");
        GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletForce * transform.localScale.x, 0));
    }*/
    public void pointerDown()
    {
        PublicVars.stopFiring = false;
        makeFireTrue();
    }
    public void pointerUp()
    {
        PublicVars.firing = false;
        PublicVars.stopFiring = true;
    }
    void makeFireTrue()
    {
        PublicVars.firing = true;
    }
    void makeFireFalse()
    {
        PublicVars.firing = false;
        if(PublicVars.stopFiring == false)
        {
            Invoke("makeFireTrue",timebtwFire);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        print("speed: "+speed);
        if(PublicVars.boosterUpHealth <=0 && PublicVars.boosterLowHealth <=0)
        {
            SceneManager.LoadScene("Death");
            //print("Died by Boosters");
        }
        else if(PublicVars.boosterUpHealth <=0)
        {
            if(decSpeed)
            {
                speed -=5f;
                decSpeed = false;
            }
            
        }
        else if(PublicVars.boosterLowHealth <=0)
        {
            if(decSpeed)
            {
                speed -=5f;
                decSpeed = false;
            }
        }
        if(PublicVars.blasterUpHealth <=0)
        {
            blasterUpFire = false;
        }
        else if(PublicVars.blasterLowHealth <=0)
        {
            blasterDownFire = false;
        }
        if(PublicVars.engineHealth <=0)
        {
            //SceneManager.LoadScene("Died");
            SceneManager.LoadScene("Death");
        }
        if(PublicVars.firing && PublicVars.beginningWave == false)
        {


            print("firing"+PublicVars.firing+PublicVars.beginningWave);
            makeFireFalse();
            if(blasterUpFire)
            {
                GameObject newBulletA = Instantiate(bullet, fireA.transform.position, Quaternion.identity);
                newBulletA.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletForce * transform.localScale.x, 0));
            }
            if(blasterDownFire)
            {
                GameObject newBulletB = Instantiate(bullet, fireB.transform.position, Quaternion.identity);
                newBulletB.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletForce * transform.localScale.x, 0));
            }
            
        }
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
        //this for boundries
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
        else if(transform.position.x <= -7.4f)
        {
            transform.position = new Vector3(-7.4f, transform.position.y, 0);
        }
        transform.Translate(Vector3.up * Time.deltaTime * speed * joystick.Vertical);
        transform.Translate(Vector3.right * Time.deltaTime * speed * joystick.Horizontal);
        
    }
    

    
}
