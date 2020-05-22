using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float upForce = 200f;
    public bool isDead = false;

    private Rigidbody2D rigidBody2D;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isDead) { return; }

        if (Input.GetMouseButtonDown(0))
        {
            rigidBody2D.velocity = Vector2.zero;
            rigidBody2D.AddForce(new Vector2(0, upForce));
        }
    }

    void OnCollisionEnter2D()
    {
        isDead = true;
        rigidBody2D.velocity = Vector2.zero;
        GameController.Instance.Die();
    }
}
