using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Leaver : MonoBehaviour
{
    public GameObject Door;
    public GameObject Door1;
    public GameObject Door2;
    public GameObject Door3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //... this took me over an hour I completely forgot else if was a thing...
        if (Door.activeInHierarchy == true)
        {
            Door.SetActive(false);
        }
        else if (Door.activeInHierarchy == false)
        {
            Door.SetActive(true);
        }
    }
}
