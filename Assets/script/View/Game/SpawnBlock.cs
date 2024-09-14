using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    [Header("�}�l�[�W���[")]
    [SerializeField] private GameManager gameManager;
    [Space(10)]

    public GameObject[] spawnObj;
    public GameObject[] startAnker;
    private GameObject bornObj;

    private const float setSpawnTimer = 3.0f;
    private float spawnTimer = setSpawnTimer;
    private float objParmeterTimer;
    private Vector3 spawnPosition;
    private int spawnCount = 0;
    private bool changeParmeter = false;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObj(0);
        spawnPosition = this.gameObject.transform.localPosition;
        objParmeterTimer = gameManager.startObjParameterTime;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        objParmeterTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            SpawnObj(1);
        }

        if (objParmeterTimer <= 0)
        {
            changeParmeter = true;
        }
    }

    private void SpawnObj(int SpawnNumber)
    {
        if (SpawnNumber != 0) spawnCount++;

        //�����_���X�|�[������I�u�W�F�N�g�̎�ސݒ�
        int rndSpwanObj = Random.Range(0, spawnObj.Length);

        //�����l�̃X�|�[��
        if (SpawnNumber == 0)
        {
            bornObj = Instantiate(spawnObj[rndSpwanObj], startAnker[1].transform.position, Quaternion.identity);
            bornObj.tag = "FixedObj";
            TimeChangeParm(bornObj);
            rndSpwanObj = Random.Range(0, spawnObj.Length);
            bornObj = Instantiate(spawnObj[rndSpwanObj], startAnker[2].transform.position, Quaternion.identity);
            bornObj.tag = "FixedObj";
            TimeChangeParm(bornObj);
        }
        //�Œ�J�E���g�Ăяo��
        else if (SpawnNumber == 1)
        {
            int rndOccurrence = RandomOrFixedSpawn(spawnCount);
            if (rndOccurrence != 0) return;
            bornObj = Instantiate(spawnObj[rndSpwanObj], spawnPosition, Quaternion.identity);
            bornObj.tag = "FixedObj";
            TimeChangeParm(bornObj);

        }
        //�����_���X�|�[��
        else if (SpawnNumber == 2)
        {
            float positionX = Random.Range(-2.0f, 2.1f);
            spawnPosition.x = positionX;
            bornObj = Instantiate(spawnObj[rndSpwanObj], spawnPosition, Quaternion.identity);
            bornObj.tag = "RandomObj";
            TimeChangeParm(bornObj);
        }
    }

    private int RandomOrFixedSpawn(int Count)
    {
        //�J�E���g��2��4�̎��Ƀ����_�����I
        int rndSpwanObj = 0;
        if (Count == 2 || Count == 4) rndSpwanObj = Random.Range(0, 2);

        //���I�ɓ���Ȃ���ΌŒ�l��ݒ�A
        if (rndSpwanObj == 0)
        {
            switch (Count)
            {
                case 1:
                    spawnPosition.x = -2.0f;
                    break;
                case 2:
                    spawnPosition.x = 0.0f;
                    break;
                case 3:
                    spawnPosition.x = 2.0f;
                    break;
                case 4:
                    spawnPosition.x = 0.0f;
                    break;
            }
        }
        else
        {
            SpawnObj(2);
        }

        spawnTimer = setSpawnTimer;
        if (Count == 4) spawnCount = 0;

        return rndSpwanObj;
    }

    private void TimeChangeParm(GameObject bornObj)
    {
        ObjMove objMove = bornObj.GetComponent<ObjMove>();
        objMove.fallingSpeed = gameManager.fallingBaseSpeed;
        objMove.rotateSpeed = gameManager.rotateBaseSpeed;

        //���Ԍo�߂ŗ������x��]���x��ύX
        if (changeParmeter)
        {
            gameManager.fallingBaseSpeed += gameManager.fallingSpeed;
            gameManager.rotateBaseSpeed += gameManager.rotateSpeed;
            objMove.fallingSpeed = gameManager.fallingBaseSpeed;
            objMove.rotateSpeed = gameManager.rotateBaseSpeed;
            objParmeterTimer = gameManager.startObjParameterTime;
            changeParmeter = false;
        }
    }
}