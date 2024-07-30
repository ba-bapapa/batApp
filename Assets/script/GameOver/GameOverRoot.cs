using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverRoot: MonoBehaviour
{
    [SerializeField] private Button titleButton;

    void Start()
    {
        titleButton.onClick.AddListener(LoadTitle);
    }

    public void LoadTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
