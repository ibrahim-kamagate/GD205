using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class class2 : MonoBehaviour
{
    public GameObject player;
    public GameObject cube1;

    // Start is called before the first frame update
    void Start()
    {
        
        
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
        // negitive affect 
        if (player == cube1) {
            player.transform.position += new Vector3(-3, 1, 6);
        }


    }
}
