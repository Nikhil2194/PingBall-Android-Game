using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] public float bounceForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        StartBounce();
    }

   
    void Update()
    {
        
            
        
    }

    void StartBounce()
    {
        Vector2 randomDirectin = new Vector2(Random.Range(-1, 1), 1);
        rb.AddForce(randomDirectin * bounceForce * Time.deltaTime, ForceMode2D.Impulse);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       if ( collision.gameObject.tag == "FallCheck")
        {
            GAmeManager.instance.Restart();
        }
    }
}
