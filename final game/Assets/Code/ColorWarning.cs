using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorWarning : MonoBehaviour
{
    public Image spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(warning());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator warning()
    {
        spriteRenderer.color = new Color(255, 0, 0);
        yield return new WaitForSeconds(1);
        spriteRenderer.color = new Color(0, 255, 0);
        yield return new WaitForSeconds(1);
    }
}
