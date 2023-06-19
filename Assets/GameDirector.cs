using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    //UIText�I�u�W�F�N�g��ۑ�����ϐ�
    public Text kyoriLabel;
    //������ۑ�����ϐ�
    int kyori;
    //�c�莞�Ԃ�ۑ�����ϐ�
    public static float lastTime;
    //timeGauge��\������UI
    public Image timeGauge;

    void Start()
    {
        //�ŏ��̋���
        kyori = 0;
        //�c�莞��
        lastTime = 100f;
    }

    void Update()
    {
        //�c�莞�Ԃ����炷����
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 100f;

        //�c�莞�Ԃ��O�ɂȂ�����Q�[���V�[���������[�h
        if (lastTime < 0) 
        {
            SceneManager.LoadScene("GameScene");
        }

        //kyori��1�t���[����1Km���₷
        kyori++;
        kyoriLabel.text = kyori.ToString("D6") + "Km";
    
    
    
    }
}
