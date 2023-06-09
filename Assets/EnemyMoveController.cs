using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMoveController : MonoBehaviour
{
    Transform player;
    float speed = 5;

    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        //X方向の移動
        Vector3 dir = Vector3.left;

        //左に見切れたら右に戻す
        if (transform.position.x < -9f) 
        {
            Vector3 pos = transform.position;
            pos.x = 9f;
            transform.position = pos;
        }

        //Y方向の移動
        //-2＜＝Sin＜＝2の間を行ったり来たり Time.time １秒に１増える
        //dir.y = 2f * Mathf.Sin(Time.time * 5f);

        //敵の移動方向をPlayerにする
        dir = player.position - transform.position;
        transform.position += dir.normalized * speed * Time.deltaTime;


    }
}
