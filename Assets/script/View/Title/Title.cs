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
        // �v���n�u���擾
        GameObject prefab = (GameObject)Resources.Load("SettingPopup");
        // �v���n�u����C���X�^���X�𐶐�
        Instantiate(prefab, canvas.position, Quaternion.identity, canvas);
    }
}