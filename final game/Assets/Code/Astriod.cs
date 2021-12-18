using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Astriod : MonoBehaviour
{
    public int astroidForce;
    public Text upperBooster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-1*astroidForce,-1*astroidForce));
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            PublicVars.boosterUpHealth -= 20f;
            upperBooster.text = PublicVars.boosterUpHealth.ToString();
            Destroy(gameObject);
        }
    }
    */
}
