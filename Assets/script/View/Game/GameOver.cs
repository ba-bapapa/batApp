using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    [Header("�}�l�[�W���[")]
    [SerializeField] private GameUIManager uiManager;
    [SerializeField] private GameManager gameManager;

    private float changeStart;
    private float changeEnd;
    private float changeSpeed;
    private float startY;        // ����Y�ʒu
    private float elapsedTime;   // changeStart�𒴂����o�ߎ���

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

        // �^�[�Q�b�g�܂ł̈ʒu�̌v�Z
        float ratio = Mathf.Clamp01(elapsedTime / changeSpeed);
        float newY = Mathf.Lerp(startY, changeEnd, ratio);

        // �V�����ʒu�̐ݒ�
        transform.localScale = new Vector3(transform.localScale.x, newY, transform.localScale.z);

        // �o�ߎ��Ԃ��w�肳�ꂽ���Ԃ𒴂����ꍇ
        if (elapsedTime >= changeSpeed)
        {
            // �ʒu���^�[�Q�b�gY�ʒu�ɌŒ�
            transform.localScale = new Vector3(transform.localScale.x, changeEnd, transform.localScale.z);
        }
    }
}