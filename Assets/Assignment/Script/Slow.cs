using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : MonoBehaviour
{

    public GameObject Vamp;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.activeInHierarchy == true)
        {
            speed = 0f;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.activeInHierarchy == true)
        {
            speed = 20f;
        }
    }
}
