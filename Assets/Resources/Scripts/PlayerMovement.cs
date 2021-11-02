using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;


public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] private float Speed = 10f;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        if(hasAuthority)
        {
            rb = GetComponent<Rigidbody2D>();
        }
        
    }

    void Update()
    {
        if (hasAuthority) //проверяем, есть ли у нас права изменять этот объект
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            float speed = 5f * Time.deltaTime;
            transform.Translate(new Vector2(h * speed, v * speed)); //делаем простейшее движение

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

    /*void Update()
    {
        if (hasAuthority)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");

            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical );
            rb.AddForce(movement * Speed);

            
        }
        
    }*/
}
