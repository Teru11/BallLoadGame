using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatWall : MonoBehaviour {

    public GameObject[] WallBlock;    //壁ブロック
    public float CreatIntervalTime = 4.0f;
    int creatPos_x, creatPos_y;    //WallBlockの生成する座標
    int max_x = 4, max_y = 10;
    int Block_index;
    int BlockPatern;
    PlayerMove playerMove;
    IEnumerator creatWallTime;
    
	// Use this for initialization
	void Start () {
        playerMove = FindObjectOfType<PlayerMove>();
        creatWallTime = CreatWallBlock();
        StartCoroutine(creatWallTime);
	}

    private void Update()
    {
        if (!playerMove.moved)
        {
            StopCoroutine(creatWallTime);
        }
    }

    IEnumerator CreatWallBlock()
    {
        while (true)
        {
            BlockPatern = Random.Range(0, 10);
            if (BlockPatern >= 5)
            {
                PaternA();
            }
            else
            {
                PaternB();
            }

                yield return new WaitForSeconds(CreatIntervalTime);
        }
    }

    //パターンA
    void PaternA()
    {
        Block_index = 1;
        int i;
        for (i = 0; i < 2; i++)
        {
            creatPos_x = Random.Range(-max_x, max_x + 1);
            creatPos_y = (int)transform.position.y;
            Instantiate(WallBlock[Block_index], new Vector3(creatPos_x, creatPos_y, transform.position.z), Quaternion.identity);
        }
    }

    //パターンB
    void PaternB()
    {
        Block_index = 2;
        int i;
        for (i = 0; i < 2; i++)
        {
            creatPos_x = (int)transform.position.x;
            creatPos_y = Random.Range(1, max_y+1);
            Instantiate(WallBlock[Block_index], new Vector3(creatPos_x, creatPos_y, transform.position.z), Quaternion.identity);
        }
    }

}
