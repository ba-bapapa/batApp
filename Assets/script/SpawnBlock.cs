using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    public GameObject[] spawnObj;
    public GameObject[] startAnker;

    private GameObject bornObj;
    private const float setTimer = 3.0f;
    private float timer = setTimer;
    private Vector3 spawnPosition;
    private int spawnCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObj(0);
        spawnPosition = this.gameObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnObj(1);
        }
    }

    private void SpawnObj(int SpawnNumber)
    {
        if(SpawnNumber != 0) spawnCount++;

        //�����_���X�|�[������I�u�W�F�N�g�̎�ސݒ�
        int rndSpwanObj = Random.Range(0, spawnObj.Length);

        //�����l�̃X�|�[��
        if(SpawnNumber == 0)
        {
            bornObj = Instantiate(spawnObj[rndSpwanObj], startAnker[1].transform.position, Quaternion.identity);
            bornObj.tag = "FixedObj";
            rndSpwanObj = Random.Range(0, spawnObj.Length);
            bornObj = Instantiate(spawnObj[rndSpwanObj], startAnker[2].transform.position, Quaternion.identity);
            bornObj.tag = "FixedObj";
        }
        //�Œ�J�E���g�Ăяo��
        else if(SpawnNumber == 1)
        {
            int rndOccurrence = RandomOrFixedSpawn(spawnCount);

            //�����_�����I���N���Ȃ���΃I�u�W�F�N�g�쐬
            if(rndOccurrence == 0)
            {
                bornObj = Instantiate(spawnObj[rndSpwanObj], spawnPosition, Quaternion.identity);
                bornObj.tag = "FixedObj";
            }
        }
        //�����_���X�|�[��
        else if(SpawnNumber == 2)
        {
            float positionX = Random.Range(-2.0f, 2.1f);
            spawnPosition.x = positionX;
            bornObj = Instantiate(spawnObj[rndSpwanObj], spawnPosition, Quaternion.identity);
            bornObj.tag = "RandomObj";
        }

        timer = setTimer;
    }

    private int RandomOrFixedSpawn(int Count)
    {
        //�J�E���g��2��4�̎��Ƀ����_�����I
        int rndSpwanObj = 0;
        if (Count == 2 || Count == 4) rndSpwanObj = Random.Range(0, 2);

        //���I�ɓ���Ȃ���ΌŒ�l��ݒ�A
        if(rndSpwanObj == 0)
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

        if (Count == 4) spawnCount = 0;

        return rndSpwanObj;
    }
}