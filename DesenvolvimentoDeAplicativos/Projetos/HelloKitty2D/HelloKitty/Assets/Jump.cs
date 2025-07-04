using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jump = 15f; 
    public bool OnFloor = false;
    public int JumpLeft = 2;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void JumpAction()
    {
        rb.AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (OnFloor == true && JumpLeft == 2 || JumpLeft == 1)
            {
                JumpAction();
                JumpLeft--;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.CompareTag("Floor"))
        {
            OnFloor = true;
            JumpLeft = 2;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor")) OnFloor = false;
    }
}
