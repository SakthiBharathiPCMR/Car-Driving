using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //private float moveSpeed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody rb;

    [SerializeField] private float horsePower = 1f;
    [SerializeField] private Transform centerOfMassTransform;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      //  rb.centerOfMass = centerOfMassTransform.position;
        //switching camera

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        //switching camera

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }


        //getting input from user
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // move the vehicle 
        // transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * forwardInput);
        rb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);

        // rotate the vehicle 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
