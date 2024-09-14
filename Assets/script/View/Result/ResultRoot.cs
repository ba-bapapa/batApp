using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ResultRoot : MonoBehaviour
{
    [SerializeField] private Button titleButton;
    [SerializeField] private TextMeshProUGUI bestTimeText;
    [SerializeField] private TextMeshProUGUI nowTimeText;

    private float bestTime;
    private float nowTime;

    void Start()
    {
        nowTime = PlayerPrefs.GetFloat("ScoreTime");
        bestTime = PlayerPrefs.GetFloat("BestTime");

        //スコア表示
        nowTimeText.text = nowTime.ToString("f0");
        bestTimeText.text = bestTime.ToString("f0");

        //ベストスコア更新
        if (nowTime > bestTime)
        {
            bestTimeText.text = "new " + nowTime.ToString("f0");
            PlayerPrefs.SetFloat("BestTime", nowTime);
        }

        titleButton.onClick.AddListener(LoadTitle);
    }

    public void LoadTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
