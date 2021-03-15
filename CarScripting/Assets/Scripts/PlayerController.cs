using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float turnSpeed = 75.0f;
    private float speed = 30.0f ;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update(){
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical"); 
        //Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        //Rotate the car based on horizontal inut
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed*horizontalInput);}
}
