using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enviroment : MonoBehaviour
{
    public float backgroundStaticSpeed = .005f;
    private Renderer backgroundRenderer;
    private float movingVerticalMutliplier = 0;
    private float movingHorizontalMutliplier = 0;

    // Start is called before the first frame update
    void Start()
    {
        backgroundRenderer.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
