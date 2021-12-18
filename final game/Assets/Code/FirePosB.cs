using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePosB : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BlasterLow;
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
            print("colliding with ship");
            PublicVars.blasterLowHealth -= 10f;
            //engine.text = PublicVars.engineHealth.ToString();
            BlasterLow.GetComponent<HealthBar>().SetHealth(PublicVars.blasterLowHealth);
            //Destroy(collision.gameObject);
        }
        else if(other.gameObject.tag=="bulletUpDown")
        {
            print("colliding with ship");
            PublicVars.blasterLowHealth -= 10f;
            //engine.text = PublicVars.engineHealth.ToString();
            BlasterLow.GetComponent<HealthBar>().SetHealth(PublicVars.blasterLowHealth);
        }
        else if(other.gameObject.tag=="Astroidleftright")
        {
            PublicVars.blasterLowHealth -= 100f;
            //engine.text = PublicVars.engineHealth.ToString();
            BlasterLow.GetComponent<HealthBar>().SetHealth(PublicVars.blasterLowHealth);
            //instantiate fire
        }
    }
}
