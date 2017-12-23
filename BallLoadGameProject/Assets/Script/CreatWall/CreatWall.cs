using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatWall : MonoBehaviour {

    public GameObject[] WallBlock;    //壁ブロック
    public float CreatIntervalTime = 4.0f;
    int creatPos_x, creatPos_y;    //WallBlockの生成する座標
    int max_x = 4;
    int Block_index;

	// Use this for initialization
	void Start () {
        StartCoroutine("CreatWallBlock");
	}

    IEnumerator CreatWallBlock()
    {
        while (true)
        {
           PaternA();        
            yield return new WaitForSeconds(CreatIntervalTime);
        }
    }

    //パターンA
    void PaternA()
    {
        Block_index = 1;
        creatPos_x = Random.Range(-max_x, max_x+1);
        creatPos_y = (int)transform.position.y;
        Instantiate(WallBlock[Block_index], new Vector3(creatPos_x, creatPos_y, transform.position.z), Quaternion.identity);
    }
	
	
}
