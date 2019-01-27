using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    /// <summary>
    /// Handle UI Manager Object here. 
    /// </summary>
    public Text ScoreText;
    public GameObject GameScreen;
    public GameObject ReadyScreen;
    public GameObject GameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClickToPlay()
    {
        ScoreText.text = "Score: 0";
        GameScreen.SetActive(true);
        GameManager.SetActive(true);

        ReadyScreen.SetActive(false);

     //   Cursor.visible = false;
    }

    void EndGame()
    {
        GameScreen.SetActive(false);
        GameManager.SetActive(false);
        ReadyScreen.SetActive(true);
    }
}
