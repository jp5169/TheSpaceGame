using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployPowerUp : MonoBehaviour
{
    public GameObject powerPrefab;
    public float respawnTime = 1f;
    void Start()
    {
        //print("hello");
        StartCoroutine(powerWave());
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
        Instantiate(powerPrefab, new Vector2(10f,yrange),Quaternion.identity);
    }
    IEnumerator powerWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            Spawn();

        }
    }
}
