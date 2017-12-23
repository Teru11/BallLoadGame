using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour {

    Rigidbody rb;
    public float m_TurnSpeed;


	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    void FixedUpdate()
    {
        Turn();
    }

    //ボールの回転
    private void Turn()
    {
        //Y軸回りの回転角を求める
        float turn = m_TurnSpeed * Time.deltaTime;
        //回転のクォータニオンを求める
        Quaternion turnRotaion = Quaternion.Euler(turn, 0f, 0f);

        //Rigidbodyの回転
        rb.MoveRotation(rb.rotation * turnRotaion);
    }
}
