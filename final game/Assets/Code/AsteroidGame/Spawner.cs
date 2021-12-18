using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject decoy;
    public GameObject target;
    public float amount;
    float x;
    float y;
    Vector2 pos;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObject(target);
        for (int i = 0; i < amount; i++)
        {
            SpawnObject(decoy);
        }
    }

    public void SpawnObject(GameObject thing)
    {
        x = Random.Range(-6, 6);
        y = Random.Range(-4, 4);
        pos = new Vector2(x, y);
        Instantiate(thing, pos, Quaternion.identity);

    }
}
