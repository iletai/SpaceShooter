using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    [Header("Player General")]
    public int LifeCount = 5;
    [Range(3,15)]
    public float speedMove;
    public float RocketDelayAfterShoot;
   

    [Header("Rocket General")]
    public GameObject RocketPrefab;
    public float RocketDistanceForward;
    public float RocketDistanceRight;
    public Vector3 RocketRotation;

    [Header("Other General")]
    public GameManager GameMgr;
    protected bool isCanShoot = true;


    protected void EnableShootRocket()
    {
        isCanShoot = true;
    }

    protected void ShooterRocket()
    {
        GameObject.Instantiate(RocketPrefab, transform.position + Vector3.forward * RocketDistanceForward + Vector3.right * RocketDistanceRight,Quaternion.Euler(RocketRotation));
        Invoke("EnableShootRocket", RocketDelayAfterShoot);//this line delay after shoot of enemy or player
    }
    
}
