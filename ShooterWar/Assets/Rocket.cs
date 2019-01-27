using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, transform.position += Vector3.forward, 8f * Time.deltaTime);
    }

    void CheckCollisionAnDestroy()
    {

    }
}
