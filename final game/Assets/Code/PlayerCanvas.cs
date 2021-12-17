using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvas : MonoBehaviour
{

    public GameObject playerMenu;
    public SpriteRenderer spriteRender;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Camera.main.orthographicSize == 5){
            PlayerMenu(false);
        }
        if(Camera.main.orthographicSize == 1){
            PlayerMenu(true);
        }
    }

    void PlayerMenu(bool zoomValue){
        if(zoomValue){
            spriteRender.enabled = false;
            playerMenu.SetActive(true);

        }
        else{
            
            playerMenu.SetActive(false);
            spriteRender.enabled = true;
        }
    }
}
