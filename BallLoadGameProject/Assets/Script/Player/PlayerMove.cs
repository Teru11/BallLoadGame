using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private Rigidbody rb;
    private float inputHorizontal;
    public float m_Speed;
    public float m_SideSpeed;
    public bool moved = true;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>(); //Rigidbodyに参照する
	}
	
	// Update is called once per frame
	void Update () {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
	}

    void FixedUpdate()
    {
        if (moved)
        {
            //カメラの方向から、　x-z平面の単位ベクトルを取得
            Vector3 cameraForward = (Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized);

            //方向キーの入力値とカメラの向きから、移動方向を決定
            Vector3 moveForward = cameraForward + Camera.main.transform.right * inputHorizontal * m_SideSpeed;

            //移動方向にスピードを掛ける。
            rb.velocity = moveForward * m_Speed;
        }
    }

    public bool Moved()
    {
        return moved;
    }
}
