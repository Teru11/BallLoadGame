using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    //あったたらTriggerになっていないものすべて消す
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }

    //あったたらTriggerになってるものすべて消す
    private void OnTriggerEnter(Collider collision)
    {
        Destroy(collision.gameObject);
    }
}
