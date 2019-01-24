using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLevelGame : MonoBehaviour
{

    public GameObject loadingScene;
    public int sceneValue;

    public void MoveScene()
    {
        StartCoroutine(LoadAsynchronously(sceneValue));
    }

    public void GetLevel(int sceneIndex)
    {
        sceneValue = sceneIndex;
        Debug.Log(sceneIndex);
    }

    public void LoadLevel(Text levelText)
    {
        levelText.color = Color.white;
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
}
