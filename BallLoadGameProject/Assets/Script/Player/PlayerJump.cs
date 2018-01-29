using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

    public float flap = 1000f;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Space))
            Jump();

        if (Input.GetKeyDown(KeyCode.B))
            Down();
	}

    private void Jump()
    {
        rb.AddForce(Vector3.up * flap);
    }

    private void Down()
    {
        rb.AddForce(Vector3.down * flap);
    }
}
