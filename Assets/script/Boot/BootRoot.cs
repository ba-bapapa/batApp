using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootRoot : MonoBehaviour
{
    [SerializeField] private GameObject eventSystem;

    void Start()
    {
        DontDestroyOnLoad(eventSystem);
        SceneManager.LoadScene("Title");
    }
}