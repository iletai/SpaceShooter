using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : ProjectManager
{
    public float moveSpeed = 0.5f;
    public float jumpForce = 5.0f;
    public Rigidbody2D circle;
    public string currentColor;
    public SpriteRenderer sr;
    public Color blue;
    public Color yellow;
    public Color pink;
    public Color purple;
    public Text score;

    public int scorePlayer;
    // Start is called before the first frame update
    void Start()
    {
        scorePlayer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

    }

    /// <summary>
    /// This void help to jump player 
    /// </summary>
    void Jump()
    {
        scorePlayer += 1;
        score.text = "Score:" + scorePlayer;
        circle.velocity = Vector2.up * jumpForce;
    }

    /// <summary>
    /// Set Color after player move circle
    /// </summary>
    void ChangeColor()
    {

    }
}
