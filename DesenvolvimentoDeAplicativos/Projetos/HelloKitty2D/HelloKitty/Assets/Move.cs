using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour
{
    public Vector3 movement;
    public float speed = 3f;
    private Rigidbody2D rb;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
    }
}