using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //“G‚ÌƒvƒŒƒnƒu‚ð•Û‘¶‚·‚é•Ï”
    public GameObject enemyPre;
    //“G‚ÌoŒ»•p“x‚ÌƒJƒEƒ“ƒg
    float delta;
    //“G‚ÌoŒ»•p“x
    float span;

    void Start()
    {
        delta = 0;
        span = 1f;
    }

    void Update()
    {
        //oŒ»•p“x‚ÌƒJƒEƒ“ƒg‚ð‰ÁŽZ
        delta += Time.deltaTime;
        //oŒ»•p“x‚ÌƒJƒEƒ“ƒg‚ª‚PˆÈã‚È‚ç’Ê‚é
        if (delta > span) 
        {
            //“G‚ð¶¬‚·‚é
            GameObject go = Instantiate(enemyPre);
            float py = Random.Range(-6f, 7f);
            go.transform.position = new Vector3(10, py, 0);
            //oŒ»•p“x‚ÌƒJƒEƒ“ƒg‚ð‚OƒNƒŠƒA‚·‚é
            delta = 0;
            //“G‚ÌoŒ»•p“x‚ð’Z‚­‚µ‚Ä‚¢‚­
            //ðŒ‰‰ŽZŽq@span‚ª‚OD‚T‚æ‚è‘å‚«‚¯‚ê‚Î‚OD‚O‚P‚ðˆø‚­@¬‚³‚¯‚ê‚Î‚O‚ðˆø‚­
            span -= (span > 0.5f) ? 0.01f : 0f;
        }

    }
    
}
