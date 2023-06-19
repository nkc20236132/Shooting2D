using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�ړ�������ۑ�����ϐ�
    Vector3 dir = Vector3.zero;
    //�v���C���[�̓����X�s�[�h
    float speed = 5;
    //Animator�R���|�[�l���g��ۑ�����ϐ�
    Animator anim;

    void Start()
    {
        //Animator�R���|�[�l���g�̏���ۑ�
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //�ړ�����
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        //��ʓ��ړ�����
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -9f, 9f);
        position.y = Mathf.Clamp(position.y, -5f, 5f);
        transform.position = position;

        //�A�j���[�V�����ݒ�
        if(dir.y == 0)
        {
            //�A�j���[�V�����N���b�v�uPlayer�v���Đ�
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
