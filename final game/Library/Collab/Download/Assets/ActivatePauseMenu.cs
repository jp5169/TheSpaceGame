using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePauseMenu : MonoBehaviour
{

    public GameObject pauseMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pauseMenuButton(){
        Time.timeScale = 0f;
        pauseMenuCanvas.SetActive(true);

    }

    public void resumeMenuButton(){
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
