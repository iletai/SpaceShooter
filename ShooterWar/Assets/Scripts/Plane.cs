using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : AttackManager
{
    public UIManager GameUI;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") < 0) //Move left
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.left, speedMove * Time.deltaTime);
        }
        else if (Input.GetAxis("Horizontal") > 0) //Move Right
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - Vector3.left, speedMove * Time.deltaTime);
        }

        if (Input.GetAxis("Vertical") > 0) //Move up
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.up, speedMove * Time.deltaTime);
            Debug.Log("MoveUP");
        }
        else if (Input.GetAxis("Vertical") < 0) //Move down
        {
            transform.position = Vector3.Lerp(transform.position, transform.position - Vector3.up, speedMove * Time.deltaTime);
            Debug.Log("MoveDown");
        }

        if (Input.GetAxis("Jump") > 0 && isCanShoot)
        {
            isCanShoot = false;
            ShooterRocket();
        }
    }
}
