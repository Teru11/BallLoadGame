using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private Text scoreText;
    private int score;
    private int highScore;
    public bool textmove = false; 
    PlayerMove playermove;
    private string key = "HIGH SCORE"; //ハイスコアの保存先キー 

   
   // Use this for initialization
    void Start () {
        playermove = FindObjectOfType<PlayerMove>();
        scoreText = GetComponent<Text>();
        score = 0;
        scoreText.text =  "Socre : " + score.ToString();

        //保存されていなければ0が返る
        highScore = PlayerPrefs.GetInt(key, 0);
    }
	
	// Update is called once per frame
	void Update () {



        if (playermove.moved)
        {
            score++;
        }
        else
            textmove = true;

        scoreText.text = "Score : " + score.ToString();

        //ハイスコアより現在スコアが高い時
        if (score > highScore)
        {
            //ハイスコア更新
            highScore = score;
            //ハイスコアを保存
            PlayerPrefs.SetInt(key, highScore);
        }
    }
}
