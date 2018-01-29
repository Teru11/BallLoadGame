using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour {

    private Image fadeImage;    //Image参照用
    public float fadeSpeed = 0.04f; //フェードのスピード
    private float red, green, blue, alfa;   //Imageのカラー
    PlayerMove playerMove;


    // Use this for initialization
    void Start () {
        fadeImage = GetComponent<Image>();  //Image参照
        playerMove = FindObjectOfType<PlayerMove>();

        //Imageのカラーの値を取得
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }
	
	// Update is called once per frame
	void Update () {

        //フェードイン開始(Load最初）
        if (!playerMove.moved)
            StartFadeOut();
    }


    //フェードイン
    void StartFadeOut()
    {
        if (alfa <= 0.7f)
        {
            fadeImage.enabled = true;   //Panelを表示
            alfa += fadeSpeed;  //アルファ値を徐々に下げる
            SetAlfa();  //カラーの更新
        }
    }

    //PanelのImageのカラーの更新
    private void SetAlfa()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
