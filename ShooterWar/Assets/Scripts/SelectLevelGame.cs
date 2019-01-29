using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevelGame : MonoBehaviour
{

    public GameObject loadingScene;
    public Text level1;
    public Text level2;
    public Text level3;

    enum ColorText
    {
        WHITE,
        BLACK
    }

    public int sceneValue;

    public void MoveScene()
    {
        StartCoroutine(LoadAsynchronously(sceneValue));
    }

    public void GetLevel(int sceneIndex)
    {
        sceneValue = sceneIndex;
        switch (sceneIndex)
        {
            case 2:
                level2.color = Color.black;
                level3.color = Color.black;
                break;
            case 3:
                level1.color = Color.black;
                level3.color = Color.black;
                break;
            case 4:
                level1.color = Color.black;
                level2.color = Color.black;
                break;
            default:
                break;
        }
    }

    public void LoadLevel(Text levelText)
    {
        levelText.color = Color.white;
        ReSetColorButton();
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScene.SetActive(true);
        while (!operation.isDone)
        {
            yield return null;
        }
    }

    void ReSetColorButton()
    {

    }

}
