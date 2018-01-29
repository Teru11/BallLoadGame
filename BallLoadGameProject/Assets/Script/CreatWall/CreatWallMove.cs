using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatWallMove : MonoBehaviour {

    public Transform player;
    public float distance = 100f;

    // Update is called once per frame
    void Update () {
        Vector3 creatWllPosition = new Vector3(0, 5, player.position.z);
        Vector3 relativePos = new Vector3(0, 0, distance);
        transform.position = creatWllPosition + relativePos;
	}
}
