using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int max_x;
    public int max_y;
    public float GravityPower = 9.8f;
    public GameObject explosion;
    PlayerMove playerMove;
    Rigidbody rb;

    void Start()
    {
        playerMove = GetComponent<PlayerMove>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {

        Physics.gravity = Vector3.down * GravityPower * Time.deltaTime * 1000f;

        //移動距離を制限
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -max_x,max_x),
        Mathf.Clamp(transform.position.y,0,max_y), transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        bool isWallBlock = collision.gameObject.GetComponent<WallBlock>() != null;

        if (isWallBlock)
        {
            playerMove.moved = false;
            rb.isKinematic = true;
            Instantiate(explosion, this.transform.position, Quaternion.identity);
        }
    }
}
