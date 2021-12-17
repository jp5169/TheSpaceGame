using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        PublicVars.paused = true;
        Time.timeScale = 0f;
        pauseMenuCanvas.SetActive(true);

    }

    public void resumeMenuButton(){
        PublicVars.paused = false;
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
    }

    public void restartButton(){
        
        PublicVars.engineHealth = 100f;
        PublicVars.blasterUpHealth = 100f;
        PublicVars.blasterLowHealth = 100f;
        PublicVars.boosterUpHealth = 100f;
        PublicVars.boosterLowHealth = 100f;
        SceneManager.LoadScene("Main");
    }

    public void homeButton(){
        SceneManager.LoadScene("TitleMenu");
    }

    public void quitButton(){
        Application.Quit();
    }
}
