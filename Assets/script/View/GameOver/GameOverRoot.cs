using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverRoot: MonoBehaviour
{
    [SerializeField] private Button resultButton;

    void Start()
    {
        resultButton.onClick.AddListener(LoadResult);
    }

    public void LoadResult()
    {
        SceneManager.LoadScene("Result");
    }
}
