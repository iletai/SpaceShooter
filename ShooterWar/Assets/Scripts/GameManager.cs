using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("UIManager")]
    public UIManager UserInterfaceManager;

    [Header("Spawning")]
    public bool SpawnEnemy;
    public GameObject Player;
    public List<GameObject> EnemyObject = new List<GameObject>();
    public List<GameObject> SpawnPoint = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        TriggerPlayer(true);
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

    void EndGamePlay()
    {
        TriggerPlayer(false);

    }
}
