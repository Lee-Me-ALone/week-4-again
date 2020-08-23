using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAndPrint : MonoBehaviour
{

    int i = 0;
    public Renderer rend;
    int x;
    //int x = Random.Range(200, 250);

    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Red") &&  i == 100)
            gameObject.SetActive(false);

        if (gameObject.CompareTag("Blue") && i == x)
            rend.enabled = false;

        Debug.Log(gameObject.name + ":" + i);
        i++;
    }
}
