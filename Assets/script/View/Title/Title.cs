using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button settingButton;
    [SerializeField] private Transform canvas;

    void Start()
    {
        startButton.onClick.AddListener(LoadStart);
        settingButton.onClick.AddListener(OpenSettingPopup);
    }

    private void LoadStart()
    {
        SceneManager.LoadScene("Game");
    }

    private void OpenSettingPopup()
    {
        // プレハブを取得
        GameObject prefab = (GameObject)Resources.Load("SettingPopup");
        // プレハブからインスタンスを生成
        Instantiate(prefab, canvas.position, Quaternion.identity, canvas);
    }
}