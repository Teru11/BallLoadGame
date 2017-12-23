using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int max_x;
    public int max_y;
	
	// Update is called once per frame
	void Update () {

        //移動距離を制限
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -max_x,max_x),
        Mathf.Clamp(transform.position.y,-max_y,max_y), transform.position.z);
    }
}
