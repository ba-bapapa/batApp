using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootRoot : MonoBehaviour
{
    [SerializeField] private GameObject eventSystem;
    [SerializeField] private GameObject soundManager;

    void Start()
    {
        DontDestroyOnLoad(eventSystem);
        DontDestroyOnLoad(soundManager);
        SceneManager.LoadScene("Title");
    }
}