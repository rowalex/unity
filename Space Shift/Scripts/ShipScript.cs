using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour {

    private Rigidbody2D rg2d;

    private int key = 0;

    private float vert;
    private float hor;

    public float speed;
    public float speedr;

    // Use this for initialization
    void Start()
    {

        rg2d = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        vert = Input.GetAxis("Vertical");
        hor = Input.GetAxis("Horizontal");

        rg2d.AddForce(transform.up * speed * vert * Time.deltaTime, ForceMode2D.Force);

        transform.Rotate(new Vector3(0, 0, -hor * speedr * Time.deltaTime));

        if (Input.GetKeyUp(KeyCode.W))
        {
        
                Application.LoadLevel("SampleScene");
            
        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("key"))

        {
            key = key + 1;
            Destroy(other.gameObject);
        }
 

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (key >= 1 && other.gameObject.CompareTag("port"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("c1"))
        {
            Application.LoadLevel("SampleScene");
        }
        if (other.gameObject.CompareTag("c2"))
        {
            Application.LoadLevel("SampleScene");
        }
        if (other.gameObject.CompareTag("c3"))
        {
            Application.LoadLevel("SampleScene");
        }


    }



}
