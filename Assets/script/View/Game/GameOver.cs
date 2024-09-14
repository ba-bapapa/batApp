using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    [Header("マネージャー")]
    [SerializeField] private GameUIManager uiManager;
    [SerializeField] private GameManager gameManager;

    private float changeStart;
    private float changeEnd;
    private float changeSpeed;
    private float startY;        // 初期Y位置
    private float elapsedTime;   // changeStartを超えた経過時間

    // Start is called before the first frame update
    void Start()
    {
        changeStart = gameManager.changeStartTime;
        changeEnd = gameManager.changeEndScale;
        changeSpeed = gameManager.changeTime;
        startY = transform.localScale.y;
        elapsedTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(uiManager.elapsed_time > changeStart)
        {
            elapsedTime = uiManager.elapsed_time - changeStart;
            RisingBar();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
            return;
        }
        Destroy(collision.gameObject, 2.0f);
    }

    private void RisingBar()
    {
        float currentY = transform.localScale.y;

        if (currentY > changeEnd)
        {
            return;
        }

        // ターゲットまでの位置の計算
        float ratio = Mathf.Clamp01(elapsedTime / changeSpeed);
        float newY = Mathf.Lerp(startY, changeEnd, ratio);

        // 新しい位置の設定
        transform.localScale = new Vector3(transform.localScale.x, newY, transform.localScale.z);

        // 経過時間が指定された時間を超えた場合
        if (elapsedTime >= changeSpeed)
        {
            // 位置をターゲットY位置に固定
            transform.localScale = new Vector3(transform.localScale.x, changeEnd, transform.localScale.z);
        }
    }
}