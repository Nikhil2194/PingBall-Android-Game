using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] public float moveSpeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
     
    }

   
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TouchMove();
    }


    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchpos.x <0)
            {
                rb.velocity = Vector2.left * moveSpeed*Time.deltaTime;
            }
            else
            {
                rb.velocity = Vector2.right * moveSpeed * Time.deltaTime;
            }
        }

        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
