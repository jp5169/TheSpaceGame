using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AstroidLeftRight : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    private Rigidbody2D rb;
    private Vector2 screenbounds;
    public Text lowerBlaster;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -11f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            PublicVars.blasterLowHealth -= 20f;
            lowerBlaster.text = PublicVars.blasterLowHealth.ToString();
            Destroy(gameObject);
        }
    }
}
