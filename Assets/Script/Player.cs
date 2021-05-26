using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rb;
    public float maplength;
    public float maplength1;
    
   
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {

        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"),0f * Time.fixedDeltaTime);
        Vector2 newpos = rb.position + movement;
        

        newpos.x = Mathf.Clamp(newpos.x, -maplength1, maplength);
        rb.MovePosition(newpos);

    }

  
}
