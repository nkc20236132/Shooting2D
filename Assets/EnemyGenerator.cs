using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //敵のプレハブを保存する変数
    public GameObject enemyPre;
    //敵の出現頻度のカウント
    float delta;
    //敵の出現頻度
    float span;

    void Start()
    {
        delta = 0;
        span = 1f;
    }

    void Update()
    {
        //出現頻度のカウントを加算
        delta += Time.deltaTime;
        //出現頻度のカウントが１以上なら通る
        if (delta > span) 
        {
            //敵を生成する
            GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10, py, 0);
            //出現頻度のカウントを０クリアする
            delta = 0;
            //敵の出現頻度を短くしていく
            //条件演算子　spanが０．５より大きければ０．０１を引く　小さければ０を引く
            span -= (span > 0.5f) ? 0.01f : 0f;
        }

    }
    
}
