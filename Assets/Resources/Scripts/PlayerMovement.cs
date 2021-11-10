using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;


public class PlayerMovement : NetworkBehaviour
{
    //private Rigidbody2D rb;

    void Start()
    {
        if (hasAuthority)
        {
            //rb = GetComponent<Rigidbody2D>();
        }

    }

    void Update()
    {
        if (hasAuthority) //проверяем, есть ли у нас права изменять этот объект
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            float speed = 5f * Time.deltaTime;
            transform.Translate(new Vector2(h * speed, v * speed));

            if (Input.GetAxis("Horizontal") < 0)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }

}
