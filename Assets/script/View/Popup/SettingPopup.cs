using audio;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingPopup : MonoBehaviour
{
    [SerializeField] private Button closeButton;
    [SerializeField] private Slider master;
    [SerializeField] private Slider bgm;
    [SerializeField] private Slider se;

    // Start is called before the first frame update
    void Start()
    {
        closeButton.onClick.AddListener(OnCloseButton);
        master.onValueChanged.AddListener(MasterVolumeChange);
        bgm.onValueChanged.AddListener(BgmVolumeChange);
        se.onValueChanged.AddListener(SeVolumeChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MasterVolumeChange(float value)
    {
        float decibel = 20f * Mathf.Log10(value);
        decibel = Mathf.Clamp(decibel, -80f, 0f);
        AudioManager.instance.SetMasterVolume(decibel);
    }

    private void BgmVolumeChange(float value)
    {
        float decibel = 20f * Mathf.Log10(value);
        decibel = Mathf.Clamp(decibel, -80f, 0f);
        AudioManager.instance.SetBgmVolume(decibel);
    }

    private void SeVolumeChange(float value)
    {
        float decibel = 20f * Mathf.Log10(value);
        decibel = Mathf.Clamp(decibel, -80f, 0f);
        AudioManager.instance.SetSeVolume(decibel);
    }

    private void OnCloseButton()
    {
        Destroy(this.gameObject);
    }
}
