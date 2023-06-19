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
        //X•ûŒü‚ÌˆÚ“®
        Vector3 dir = Vector3.left;

        //¶‚ÉŒ©Ø‚ê‚½‚ç‰E‚É–ß‚·
        if (transform.position.x < -9f) 
        {
            Vector3 pos = transform.position;
            pos.x = 9f;
            transform.position = pos;
        }

        //Y•ûŒü‚ÌˆÚ“®
        //-2ƒSinƒ2‚ÌŠÔ‚ğs‚Á‚½‚è—ˆ‚½‚è Time.time ‚P•b‚É‚P‘‚¦‚é
        //dir.y = 2f * Mathf.Sin(Time.time * 5f);

        //“G‚ÌˆÚ“®•ûŒü‚ğPlayer‚É‚·‚é
        dir = player.position - transform.position;
        transform.position += dir.normalized * speed * Time.deltaTime;


    }
}
