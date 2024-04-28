using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject timeUi;
    private TextMeshProUGUI timeText;
    private float elapsed_time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        timeText = timeUi.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        elapsed_time += Time.deltaTime;
        float textTime = Mathf.Floor(elapsed_time);
        timeText.text = textTime.ToString();
    }
}