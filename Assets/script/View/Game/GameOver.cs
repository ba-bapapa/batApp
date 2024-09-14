using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    [Header("�o�[���オ�肾���J�n�b��")]
    [SerializeField] private float changeStart;

    [Header("�o�[���ǂ��܂ŏオ�邩")]
    [SerializeField] private float changeEnd;

    [Header("�o�[��changeEnd�܂ł̓��B�X�s�[�h")]
    [SerializeField] private float changeSpeed;

    [Space(10)]
    [SerializeField] private GameUIManager uiManager;
    private float startY;        // ����Y�ʒu
    private float elapsedTime;   // changeStart�𒴂����o�ߎ���

    // Start is called before the first frame update
    void Start()
    {
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