using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //移動方向を保存する変数
    Vector3 dir = Vector3.zero;
    //敵の移動速度
    float speed = 5;

    void Start()
    {
        //４秒後に破壊する
        Destroy(gameObject, 4f);
    }

    void Update()
    {
        //移動方向を決定
        dir = Vector3.left;
        //初期座標に移動量を足す
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //制限時間を１０秒減らす
        GameDirector.lastTime -= 10f;

        //他のオブジェクトと重なったら敵を破壊
        Destroy(gameObject);
    }

}
