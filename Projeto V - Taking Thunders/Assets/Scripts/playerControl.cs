using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Rigidbody rb;
    public float playerSpeed;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        if (xAxis > 0.1)
        {
            transform.Translate(Vector3.right * xAxis * playerSpeed * Time.deltaTime);
        }
        else if (xAxis < -0.1)
        {
            transform.Translate(Vector3.right * xAxis * playerSpeed * Time.deltaTime);
        }

        if (zAxis > 0.1)
        {
            transform.Translate(Vector3.forward * zAxis * playerSpeed * Time.deltaTime);
        }
        else if (zAxis < -0.1)
        {
            transform.Translate(Vector3.forward * zAxis * playerSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("Teta");
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            Debug.Log("Teta");
        }
	}
}