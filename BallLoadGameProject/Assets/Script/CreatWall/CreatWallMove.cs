using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatWallMove : MonoBehaviour {

    private Vector3 m_pos;
    PlayerMove playMove;

    // Use this for initialization
    void Start () {
        playMove = FindObjectOfType<PlayerMove>();
        m_pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        moveFowerd();
	}

    void moveFowerd()
    {
        transform.localPosition = m_pos;  // 形状位置を更新
        m_pos.z += playMove.m_Speed * Time.deltaTime;
    }
    
}
