using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Reflection;


public class Setting : MonoBehaviour
{
    public GameObject panel;
    public Button settingButton;
    public static bool isClickButton;


    // Start is called before the first frame update
    void Start()
    {
        isClickButton = false;
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isClickButton)
        {
            //CheckSettingClicked();
            settingButton.onClick.AddListener(ShowSetting);
            isClickButton = true;
           
        }
        else
        {
            settingButton.onClick.AddListener(HideSetting);
            isClickButton = false;
        }

    }

    void ShowSetting()
    {
        panel.SetActive(true);
        Debug.Log("Mo cai dat");
    }

    void HideSetting()
    {
        panel.SetActive(false);
        Debug.Log("Tat cai dat");
    }
}
