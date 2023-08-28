using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i = 3;
    private int randint;
    // Start is called before the first frame update
    void Start()
    {
        randint = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(transform.name + ":" + i);
        if (transform.tag == "Red" && i == 100)
        {
            rend.enabled = false;
        }
        if (transform.tag == "Blue" && i == randint)
        {
            rend.enabled = false;
        }
    }
}
