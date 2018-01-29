using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMove : MonoBehaviour {

    Score score;

    private void Start()
    {
        score = GetComponent<Score>();
    }


    // Update is called once per frame
    void Update () {
        if(score.textmove)
            ScoreTextMove();
	}

    public  void ScoreTextMove()
    {
        Vector3 pos = new Vector3(400,200, 0);
        //pos = Camera.main.WorldToViewportPoint(pos);
        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
    }
}
