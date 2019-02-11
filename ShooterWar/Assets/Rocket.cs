using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public int dameRocket;
    public bool enemyRocket;
    
    // Update is called once per frame
    void Update()
    {
        ///Detect Weapon of Enemy or Player here
        if (enemyRocket)
            transform.position = Vector3.Lerp(transform.position, transform.position -= Vector3.up, 8f * Time.deltaTime);
        else
            transform.position = Vector3.Lerp(transform.position, transform.position += Vector3.up, 8f * Time.deltaTime);
     }

    public void OnCollisionEnter(Collision collision)
    {
        if (enemyRocket && collision.gameObject.tag == "Player")
        {
            Debug.Log("Va cham enemy");
            Destroy(this.gameObject);
        }

        if (!enemyRocket && collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Va cham player");
            Destroy(this.gameObject);
        }

    }
}
