using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePosA : MonoBehaviour
{
    public GameObject BlasterUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag=="bullet")
        {
            //print("colliding with ship");
            PublicVars.blasterUpHealth -= 10f;
            //engine.text = PublicVars.engineHealth.ToString();
            BlasterUp.GetComponent<HealthBar>().SetHealth(PublicVars.blasterUpHealth);
            //Destroy(collision.gameObject);
        }
        else if(other.gameObject.tag=="bulletUpDown")
        {
            print("colliding with ship up down");
            PublicVars.blasterUpHealth -= 10f;
            //engine.text = PublicVars.engineHealth.ToString();
            BlasterUp.GetComponent<HealthBar>().SetHealth(PublicVars.blasterUpHealth);
        }
        else if(other.gameObject.tag=="Astroidleftright")
        {
            PublicVars.blasterUpHealth -= 100f;
            //engine.text = PublicVars.engineHealth.ToString();
            BlasterUp.GetComponent<HealthBar>().SetHealth(PublicVars.blasterUpHealth);
            //Destroy(other.gameObject);
            //instantiate fire
        }
    }
}
