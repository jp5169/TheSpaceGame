using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanCam : MonoBehaviour
{

    public float dampTime = 0.15f;

    public float y = 0;

    public float stop = -210;

    public float canvas = -200;

    public GameObject playMenu;

     // Update is called once per frame
    void Update () 
    {
        transform.position = new Vector3(0, y * dampTime, 0);
        y -= 0.5f;

        if(y < canvas){
            playMenu.SetActive(true);
        }
        if(y < stop){
            enabled = false;
        }
        else{
            enabled = true;
        }
    }
}
