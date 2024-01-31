using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Blocker;
    public GameObject Blocker1;
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

    if(Blocker.activeInHierarchy == true)
        {
            Blocker.SetActive(false);
        }

    if(Blocker1.activeInHierarchy == true)
        {
            Blocker1.SetActive(false);
        }
    }
}
