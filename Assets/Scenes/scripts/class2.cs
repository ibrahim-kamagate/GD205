using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
public class class2 : MonoBehaviour
{
    public GameObject player;
    public Transform[] hazzard;
    public int i;

    public AudioClip impact;
    AudioSource audioSource;

    Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = player.transform.position;

        audioSource = GetComponent<AudioSource>();

        
    }

     void OnCollisionEnter(){
        audioSource.PlayOneShot
    }

    // Update is called once per frameXDSA
    void Update(){
        //to go left 
        if (Input.GetKeyDown(KeyCode.A)) {

            player.transform.position += new Vector3(0, 0, 1);

        }
        //to go right
        if (Input.GetKeyDown(KeyCode.D))
        {

            player.transform.position += new Vector3(0, 0, -1);

        }
        //to go forward
        if (Input.GetKeyDown(KeyCode.W))
        {

            player.transform.position += new Vector3(1, 0, 0);

        }
        //to go backward
        if (Input.GetKeyDown(KeyCode.S))
        {

            player.transform.position += new Vector3(-1, 0, 0);

        }
        //to go up
        if (Input.GetKeyDown(KeyCode.Q))
        {

            player.transform.position += new Vector3(0, 1, 0);

        }
        //to go down
        if (Input.GetKeyDown(KeyCode.E))
        {

            player.transform.position += new Vector3(0, -1, 0);

        }

        //loop to check 
        for (int i = 0; i < hazzard.Length; i++) {
            // negitive affect 
            if (hazzard[i].position == player.transform.position) {
                player.transform.position = initPos;
            }
        }

    }
}

