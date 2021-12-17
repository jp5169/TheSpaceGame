using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployChaseEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject chaseEnemy;
    public float respawnTime = 1f;
    private Vector2 screenBounds; //= new Vector2();
    void Start()
    {
        //print("hello");
        StartCoroutine(astroidWave());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Spawn()
    {
        /* GameObject newBulletA = Instantiate(bullet, fireA.transform.position, Quaternion.identity);
            newBulletA.GetComponent<Rigidbody2D>().AddForce(new Vector2(bulletForce * transform.localScale.x, 0));*/
        float yrange=Random.Range(-4f,4f);
        //print(yrange);
    
        GameObject fire = Instantiate(chaseEnemy, new Vector2(10f,yrange),Quaternion.identity);
        fire.GetComponent<ChasingAttack>().enabled = true;
    }
    IEnumerator astroidWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            Spawn();

        }
    }
}
