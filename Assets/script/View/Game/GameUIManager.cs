using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timer;
    private float elapsed_time = 0.0f;

    void Start()
    {
    }

    void Update()
    {
        elapsed_time += Time.deltaTime;
        timer.text = elapsed_time.ToString("f0");
    }
}