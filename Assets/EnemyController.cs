using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //ˆÚ“®•ûŒü‚ğ•Û‘¶‚·‚é•Ï”
    Vector3 dir = Vector3.zero;
    //“G‚ÌˆÚ“®‘¬“x
    float speed = 5;

    void Start()
    {
        //‚S•bŒã‚É”j‰ó‚·‚é
        Destroy(gameObject, 4f);
    }

    void Update()
    {
        //ˆÚ“®•ûŒü‚ğŒˆ’è
        dir = Vector3.left;
        //‰ŠúÀ•W‚ÉˆÚ“®—Ê‚ğ‘«‚·
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //§ŒÀŠÔ‚ğ‚P‚O•bŒ¸‚ç‚·
        GameDirector.lastTime -= 10f;

        //‘¼‚ÌƒIƒuƒWƒFƒNƒg‚Æd‚È‚Á‚½‚ç“G‚ğ”j‰ó
        Destroy(gameObject);
    }

}
