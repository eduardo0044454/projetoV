using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private float posY;

    // Use this for initialization
	void Start ()
    {
        posY = transform.rotation.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //transform.rotation = new Vector3(transform.rotation.x, posY, transform.rotation.z);
	}
}
