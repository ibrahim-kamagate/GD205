using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//
public class class2 : MonoBehaviour
{
    public GameObject player;
    public GameObject endObject;
    public Transform[] hazzard;
    public int i;

    public Text playerMsg;

    AudioSource die;
    public AudioClip HazzardClip;

    AudioSource move;
    public AudioClip MoveClip;

    AudioSource end;
    public AudioClip EndClip;

    Vector3 initPos;
    // Start is called before the first frame update
    void Start()
    {
        initPos = player.transform.position;

        die = GetComponent<AudioSource>();
        move = GetComponent<AudioSource>();
        end = GetComponent<AudioSource>();


    }

    // Update is called once per frameXDSA
    void Update()
    {


        //to go left 
        if (Input.GetKeyDown(KeyCode.A))
        {

            player.transform.position += new Vector3(0, 0, 1);
                move.PlayOneShot(MoveClip);
         
        }
        //to go right
        if (Input.GetKeyDown(KeyCode.D))
        {
            
            player.transform.position += new Vector3(0, 0, -1);

                move.PlayOneShot(MoveClip);
            

        }
        //to go forward
        if (Input.GetKeyDown(KeyCode.W))
        {

            player.transform.position += new Vector3(1, 0, 0);
            move.PlayOneShot(MoveClip);

        }
        //to go backward
        if (Input.GetKeyDown(KeyCode.S))
        {

            player.transform.position += new Vector3(-1, 0, 0);
            move.PlayOneShot(MoveClip);

        }
        //to go up
        if (Input.GetKeyDown(KeyCode.Q))
        {

            player.transform.position += new Vector3(0, 1, 0);
            move.PlayOneShot(MoveClip);

        }
        //to go down
        if (Input.GetKeyDown(KeyCode.E))
        {

            player.transform.position += new Vector3(0, -1, 0);
            move.PlayOneShot(MoveClip);

        }

        //loop to check 
        for (int i = 0; i < hazzard.Length; i++)
        {
            // negitive affect 
            if (hazzard[i].position == player.transform.position)
            {
                player.transform.position = initPos;
                die.PlayOneShot(HazzardClip);

                playerMsg.text = "you DIED";

            }
        }


        if (player.transform.position == endObject.transform.position)
        {
            end.PlayOneShot(EndClip);
        }
    }



}
    