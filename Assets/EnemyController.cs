using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //�ړ�������ۑ�����ϐ�
    Vector3 dir = Vector3.zero;
    //�G�̈ړ����x
    float speed = 5;

    void Start()
    {
        //�S�b��ɔj�󂷂�
        Destroy(gameObject, 4f);
    }

    void Update()
    {
        //�ړ�����������
        dir = Vector3.left;
        //�������W�Ɉړ��ʂ𑫂�
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�������Ԃ��P�O�b���炷
        GameDirector.lastTime -= 10f;

        //���̃I�u�W�F�N�g�Əd�Ȃ�����G��j��
        Destroy(gameObject);
    }

}
