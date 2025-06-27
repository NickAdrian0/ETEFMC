using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour
{
    float speed = 3f;
    private Vector2 moveDirection;
    private Rigidbody2D rb;
    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(horizontal, vertical);
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }
    private void FixedUpdate()
    {
        Vector3 movePosition = (speed * Time.fixedDeltaTime * moveDirection.normalized) + rb.position;
        rb.MovePosition(movePosition);
    }
}
