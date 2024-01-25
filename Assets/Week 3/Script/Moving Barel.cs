using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBarel : MonoBehaviour
{
    public SpriteRenderer render;
    public Sprite barrelUp;
    public Sprite barrelDown;

    SpriteRenderer spriteRenderer;
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
        if (collision.transform.CompareTag("barrel_blue"))
        {
            render.sprite = barrelUp;
        }
        else
        {
            render.sprite = barrelDown;
        }
    }
}
