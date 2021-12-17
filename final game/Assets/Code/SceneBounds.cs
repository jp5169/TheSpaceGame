using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "bulletP" || other.gameObject.tag == "bullet" || other.gameObject.tag == "bulletUpDown")
        {
            Destroy(other.gameObject);
        }
    }
}
