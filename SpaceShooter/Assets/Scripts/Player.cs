﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;
    public Transform target;
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        speed += 1;
    }
}
