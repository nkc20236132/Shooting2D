using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //�G�̃v���n�u��ۑ�����ϐ�
    public GameObject enemyPre;
    //�G�̏o���p�x�̃J�E���g
    float delta;
    //�G�̏o���p�x
    float span;

    void Start()
    {
        delta = 0;
        span = 1f;
    }

    void Update()
    {
        //�o���p�x�̃J�E���g�����Z
        delta += Time.deltaTime;
        //�o���p�x�̃J�E���g���P�ȏ�Ȃ�ʂ�
        if (delta > span) 
        {
            //�G�𐶐�����
            GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10, py, 0);
            //�o���p�x�̃J�E���g���O�N���A����
            delta = 0;
            //�G�̏o���p�x��Z�����Ă���
            //�������Z�q�@span���O�D�T���傫����΂O�D�O�P�������@��������΂O������
            span -= (span > 0.5f) ? 0.01f : 0f;
        }

    }
    
}
