using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    [Header("Player General")]
    public int LifeCount = 5;
    public float speedMove;
    public float RocketDelayAfterShoot;
    [Range(3, 15)]
    public float SpeedRocket;

    [Header("Rocket General")]
    public GameObject RocketPrefabLeft;
    public GameObject RocketPrefabRight;
    public float RocketDistanceForward;
    public float RocketDistanceRight;
    public Vector3 RocketRotation;

    [Header("Other General")]
    public bool isCanShoot;
    public GameManager GameMgr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void EnableShootRocket()
    {
        
    }

    
}
