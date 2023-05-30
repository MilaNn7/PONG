using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    protected Rigidbody2D rb;
    public float speed = 5.0f;
   

    
   
   
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    public void ResetPosition()
    {
        rb.position = new Vector2(rb.position.x, 0.0f);
        rb.velocity = Vector2.zero;
    }
    
}

