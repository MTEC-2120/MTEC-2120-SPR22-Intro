using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 1;
    public float jump_force = 1000; 
    float move_horizontal;
    float move_vertical; 

    private void Start()
    {


        
    }


    // runs every frame
    private void Update()
    {
        //move_horizontal = Input.GetAxis("Horizontal");
        //move_vertical = Input.GetAxis("Vertical");

        //Move(move_horizontal, move_vertical);

        // Jump Button pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        //if (Input.GetAxis("Horizontal") > 0.1f)
        //{
        //    Debug.Log("Move Horizontal");
        //}


        //if (Input.GetAxis("Vertical") > 0.1f)
        //{
        //    Debug.Log("Move Vertical");
        //}

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("Space bar was pressed.");
        //}
    }


    void Move(float horizontal, float vertical)
    {
        Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        this.transform.position = position + Vector3.forward * horizontal * speed + Vector3.right * vertical * speed; 

    }

    void Jump()
    { 
        this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jump_force);


    }

}
