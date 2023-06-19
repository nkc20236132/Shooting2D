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
        //X�����̈ړ�
        Vector3 dir = Vector3.left;

        //���Ɍ��؂ꂽ��E�ɖ߂�
        if (transform.position.x < -9f) 
        {
            Vector3 pos = transform.position;
            pos.x = 9f;
            transform.position = pos;
        }

        //Y�����̈ړ�
        //-2����Sin����2�̊Ԃ��s�����藈���� Time.time �P�b�ɂP������
        //dir.y = 2f * Mathf.Sin(Time.time * 5f);

        //�G�̈ړ�������Player�ɂ���
        dir = player.position - transform.position;
        transform.position += dir.normalized * speed * Time.deltaTime;


    }
}
