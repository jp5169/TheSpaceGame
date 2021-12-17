using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    public string NextScene;
    // Update is called once per frame
    void Update()
    {
        try
        {
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.touches[0].position), Vector2.zero);


                if (hit.collider.gameObject.tag == "target")
                {
                    if (SceneManager.GetActiveScene().name == "AsteroidGame3")
                    {
                        Destroy(hit.collider.gameObject);
                        SceneManager.LoadScene(NextScene);
                        PublicVars.engineHealth = 100f;
                    }
                    else
                    {
                        Destroy(hit.collider.gameObject);
                        SceneManager.LoadScene(NextScene);
                    }
                }

                else if (hit.collider.gameObject.tag == "nontarget")
                {
                    SceneManager.LoadScene("Main3");
                }
            }
        }
        catch
        {
            print("null error");
        }
            
#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {

            try
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (hit.collider.gameObject.tag == "target")
                {
                    if(SceneManager.GetActiveScene().name == "AsteroidGame3")
                    {
                        Destroy(hit.collider.gameObject);
                        SceneManager.LoadScene(NextScene);
                        PublicVars.engineHealth = 100f;
                        PublicVars.blasterLowHealth = 100f;
                        PublicVars.blasterUpHealth = 100f;
                        PublicVars.boosterUpHealth = 100f;
                        PublicVars.boosterLowHealth = 100f;
                    }
                    else
                    {
                        Destroy(hit.collider.gameObject);
                        SceneManager.LoadScene(NextScene);
                    }
                }

                else if(hit.collider.gameObject.tag == "nontarget")
                {
                    SceneManager.LoadScene("Main3");
                }
            }
            catch
            {
                print("null error");
            }
            
        }

#endif
    }
}