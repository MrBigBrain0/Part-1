using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBarel : MonoBehaviour
{
    public GameObject barrelUp;
    public GameObject barrelDown;

    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        barrelUp.SetActive(true);
        barrelDown.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (barrelUp.activeInHierarchy)
        {
            barrelDown.SetActive(true);
            barrelUp.SetActive(false);
        }
    }
}
