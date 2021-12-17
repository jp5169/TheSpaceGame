using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButtons : MonoBehaviour
{

    public Transform panel;
    public GameObject piece;
    public float amount;
    // Start is called before the first frame update
    private void Awake()
    {
        for (int i = 0; i < amount; i++)
        {
            piece = Instantiate(piece);
            piece.name = "" + i;
            piece.transform.SetParent(panel, false);
        }
    }
}
