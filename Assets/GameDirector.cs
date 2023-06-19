using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    //UITextオブジェクトを保存する変数
    public Text kyoriLabel;
    //距離を保存する変数
    int kyori;
    //残り時間を保存する変数
    public static float lastTime;
    //timeGaugeを表示するUI
    public Image timeGauge;

    void Start()
    {
        //最初の距離
        kyori = 0;
        //残り時間
        lastTime = 100f;
    }

    void Update()
    {
        //残り時間を減らす処理
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 100f;

        //残り時間が０になったらゲームシーンをリロード
        if (lastTime < 0) 
        {
            SceneManager.LoadScene("GameScene");
        }

        //kyoriを1フレームで1Km増やす
        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "Km";
    
    
    
    }
}
