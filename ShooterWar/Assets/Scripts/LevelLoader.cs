using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScene;
    public Slider slider;

    /// <summary>
    /// Load scene by parammeter sceneIndex
    /// </summary>
    /// <param name="sceneIndex"></param>
    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScene.SetActive(true);
        while (!operation.isDone)
        {
            float process = Mathf.Clamp01(operation.progress / .9f);
            slider.value = process;
            yield return null;
        }
    }
}
