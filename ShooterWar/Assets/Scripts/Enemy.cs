using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : AttackManager
{

    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    private GameObject player;
    private float distanceToPlayer = 4f;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindObjectOfType<Plane>().gameObject;
        GameMgr = GameObject.FindObjectOfType<GameManager>();

        navMeshAgent.SetDestination(player.transform.position + Vector3.up * distanceToPlayer);
        navMeshAgent.speed = speedMove;

        navMeshAgent.Resume();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void GetNextLocation()
    {
        Vector3 destination = player.transform.position + Vector3.up * distanceToPlayer + Random.insideUnitSphere * 1;
    }

    void Move()
    {
    
    }

    void DestroyGameObject()
    {
       
    }
}
