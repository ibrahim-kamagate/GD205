using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrust : MonoBehaviour
{
    Rigidbody rb;
    public string predatorTag, preyTag;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * 2f);

        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-transform.forward * 2f);

        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * 2f);

        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * 2f);

        }
    }

    void OnCollisionEnter(Collision Mycollision)
    {
        if (Mycollision.gameObject.CompareTag(preyTag))
        {
            Destroy(Mycollision.gameObject);



        }
        else if (Mycollision.gameObject.CompareTag(predatorTag)) {
            Destroy(gameObject);


        }

        
    }
}
