using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipButtons2 : MonoBehaviour
{
    //string firstGame = "MatchingGame";
    string secGame = "AsteroidGame";
    
    //int randomNum;

    void update(){
    }
    
    public void thrusterUp(){
        /*
        randomNum = Random.Range(0, 2);
        SceneManager.LoadScene("MatchingGame");
        
        if(randomNum == 0){
            SceneManager.LoadScene(firstGame);
        }
        else{
            SceneManager.LoadScene(secGame);
        }
        */
        SceneManager.LoadScene(secGame);
    }

    public void thrusterDown(){
        /*
        randomNum = Random.Range(0, 2);
        if(randomNum == 0){
            SceneManager.LoadScene(firstGame);
        }
        else{
            SceneManager.LoadScene(secGame);
        }
        */
        SceneManager.LoadScene(secGame);
    }

    public void Engine(){
        /*
        randomNum = Random.Range(0, 2);
        if(randomNum == 0){
            SceneManager.LoadScene(firstGame);
        }
        else{
            SceneManager.LoadScene(secGame);
        }
        */
        SceneManager.LoadScene(secGame);
    }

    public void blasterUp(){
        /*
        randomNum = Random.Range(0, 2);
        if(randomNum == 0){
            SceneManager.LoadScene(firstGame);
        }
        else{
            SceneManager.LoadScene(secGame);
        }
        */
        SceneManager.LoadScene(secGame);
    }

    public void blasterDown(){
        /*
        randomNum = Random.Range(0, 2);
        if(randomNum == 0){
            SceneManager.LoadScene(firstGame);
        }
        else{
            SceneManager.LoadScene(secGame);
        }
        */
        SceneManager.LoadScene(secGame);
    }
}
