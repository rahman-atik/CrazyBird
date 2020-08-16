using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

    private Rigidbody2D rigidBody2D;

    void Start () {
        rigidBody2D = GetComponent<Rigidbody2D> ();
        rigidBody2D.velocity = new Vector2 (GameController.Instance.scrollSpeed, 0);
    }

    void Update () {
        if (GameController.Instance.isGameOver) {
            rigidBody2D.velocity = Vector2.zero;
        }
    }
}