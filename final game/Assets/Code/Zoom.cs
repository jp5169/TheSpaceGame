using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public GameObject target;
    public float zoomMin = 1;
    public float zoomMax = 5;

    private Vector3 camPos = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        camPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 2){
            print("TWOOOO TOUCHHH");

            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            print("PRE ENGINE & health:"+PublicVars.engineHealth);
            //print(touchOne.position.y);

            //print(touchZero.position.y);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMag = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMag - prevMag;

            zoom(difference * 0.01f);
            
        }
    }

    void zoom(float increment){
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10);
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomMin, zoomMax);

        if(Camera.main.orthographicSize == zoomMax){
            transform.position = camPos; 
        }
    }
}
/*
if(PublicVars.engineZoomed)
            {
                if(PublicVars.blasterLowHealth <= PublicVars.blasterLowTH)
                {
                    //warning
                    //should be able to zoom in
                    
                }
                if(PublicVars.blasterUpHealth <= PublicVars.blasterUpTH)
                {

                }
                if(PublicVars.boosterLowHealth <= PublicVars.boosterLowTH)
                {

                }
                if(PublicVars.boosterUpHealth <= PublicVars.boosterUpTH)
                {
                    
                }
                
            }
            else if(PublicVars.blasterLowZoomed)
            {
                if(PublicVars.engineHealth <= PublicVars.engineTH)
                {

                }
                if(PublicVars.blasterUpHealth <= PublicVars.blasterUpTH)
                {

                }
                if(PublicVars.boosterLowHealth <= PublicVars.boosterLowTH)
                {

                }
                if(PublicVars.boosterUpHealth <= PublicVars.boosterUpTH)
                {
                    
                }
            }
            else if(PublicVars.blasterUpZoomed)
            {
                if(PublicVars.blasterLowHealth <= PublicVars.blasterLowTH)
                {

                }
                if(PublicVars.engineHealth <= PublicVars.engineTH)
                {

                }
                if(PublicVars.boosterLowHealth <= PublicVars.boosterLowTH)
                {

                }
                if(PublicVars.boosterUpHealth <= PublicVars.boosterUpTH)
                {
                    
                }
            }
            else if(PublicVars.boosterLowZoomed)
            {
                if(PublicVars.blasterLowHealth <= PublicVars.blasterLowTH)
                {

                }
                if(PublicVars.blasterUpHealth <= PublicVars.blasterUpTH)
                {

                }
                if(PublicVars.engineHealth <= PublicVars.engineTH)
                {

                }
                if(PublicVars.boosterUpHealth <= PublicVars.boosterUpTH)
                {
                    
                }
            }
            else if(PublicVars.boosterUpZoomed)
            {
                if(PublicVars.blasterLowHealth <= PublicVars.blasterLowTH)
                {

                }
                if(PublicVars.blasterUpHealth <= PublicVars.blasterUpHealth)
                {

                }
                if(PublicVars.boosterLowHealth <= PublicVars.boosterLowTH)
                {

                }
                if(PublicVars.engineHealth <= PublicVars.engineTH)
                {
                    
                }
            }




*/
