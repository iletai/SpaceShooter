using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ProjectManager
{
    public Rigidbody2D enemy;
    public GameObject enemyBar;
    public float moveRightDistance = 3.0f;
    public Transform enemyObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.velocity.x < 300)
            Move();
        Debug.Log(enemyObject.position.y);

        if (enemyBar.transform.position.x > 5)
        {
            DestroyGameObject();
            Debug.Log("detroy");
        }
    }

    void Move()
    {
        enemy.velocity = Vector2.right * moveRightDistance;
    }

    void DestroyGameObject()
    {
        Destroy(enemyBar);
    }
}
