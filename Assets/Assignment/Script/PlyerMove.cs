using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerMove : MonoBehaviour
{
    Vector3 direction;
    public Rigidbody2D rigidbody;
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * speed * Time.deltaTime);
        transform.Rotate(0, 0, 0);
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
