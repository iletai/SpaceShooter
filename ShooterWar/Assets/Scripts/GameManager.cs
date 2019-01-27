using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("UIManager")]
    public UIManager UserInterfaceManager;

    [Header("Spawning")]
    public GameObject Player;
  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Trigger player after focus UI (Button Play)
    /// </summary>
    /// <param name="visible"></param>
    void TriggerPlayer(bool visible)
    {
        Player.SetActive(visible);
    }
}
