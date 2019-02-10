using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : AttackManager
{
    public Transform target;

    public float speedEnemy;
    public float overDistance;
    public float delayEnemy;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    void Update()
    {
        if (Vector2.Distance(transform.position,target.position) > overDistance)
            transform.position = Vector2.MoveTowards(transform.position, target.position, speedEnemy * Time.deltaTime);

        if (isCanShoot)
        {
            isCanShoot = false;
            SetDelayAfterShoot();
            ShooterRocket();
        }
    }

    public void SetDelayAfterShoot()
    {
        RocketDelayAfterShoot = delayEnemy;
    }
}
