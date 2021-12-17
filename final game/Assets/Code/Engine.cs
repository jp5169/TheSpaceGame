using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    public GameObject EngineH;
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag=="bullet")
        {
            print("colliding with ship");
            PublicVars.engineHealth -= 10f;
            //engine.text = PublicVars.engineHealth.ToString();
            EngineH.GetComponent<HealthBar>().SetHealth(PublicVars.engineHealth);
            //Destroy(collision.gameObject);
        }
        else if(other.gameObject.tag=="bulletUpDown")
        {
            print("colliding with ship");
            PublicVars.engineHealth -= 10f;
            //engine.text = PublicVars.engineHealth.ToString();
            EngineH.GetComponent<HealthBar>().SetHealth(PublicVars.engineHealth);
        }
        else if(other.gameObject.tag=="Astroidleftright")
        {
            PublicVars.engineHealth -= 100f;
            //engine.text = PublicVars.engineHealth.ToString();
            EngineH.GetComponent<HealthBar>().SetHealth(PublicVars.engineHealth);
            //Destroy(other.gameObject);
            //instantiate fire
        }
    }
}
