using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCreat : MonoBehaviour {

    public GameObject Load;
    public GameObject nextLoadPos;   

    private void OnTriggerEnter(Collider collision)
    {
        bool isPlayer = collision.gameObject.GetComponent<PlayerMove>() != null;

        if(isPlayer)
        {
            // 次の道をnextLoadPosに生成
            var obj = Instantiate(Load,nextLoadPos.transform.position, Quaternion.identity) as GameObject;
            obj.name = Load.name;
        }
    }
}
