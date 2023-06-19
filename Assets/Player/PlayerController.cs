using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //移動方向を保存する変数
    Vector3 dir = Vector3.zero;
    //プレイヤーの動くスピード
    float speed = 5;
    //Animatorコンポーネントを保存する変数
    Animator anim;

    void Start()
    {
        //Animatorコンポーネントの情報を保存
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //移動方向
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        //画面内移動制限
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -9f, 9f);
        position.y = Mathf.Clamp(position.y, -5f, 5f);
        transform.position = position;

        //アニメーション設定
        if(dir.y == 0)
        {
            //アニメーションクリップ「Player」を再生
            anim.Play("Player");
        }
        else if(dir.y == 1)
        {
            anim.Play("PlayerL");
        }
        else if (dir.y == -1) 
        {
            anim.Play("PlayerR");
        }

    }
}
