using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealSecret : MonoBehaviour
{
    public GameObject Secret1;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            Secret1.SetActive(false);
        }
    }
}
