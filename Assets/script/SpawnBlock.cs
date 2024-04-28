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

        //ランダムスポーンするオブジェクトの種類設定
        int rndSpwanObj = Random.Range(0, spawnObj.Length);

        //初期値のスポーン
        if(SpawnNumber == 0)
        {
            bornObj = Instantiate(spawnObj[rndSpwanObj], startAnker[1].transform.position, Quaternion.identity);
            bornObj.tag = "FixedObj";
            rndSpwanObj = Random.Range(0, spawnObj.Length);
            bornObj = Instantiate(spawnObj[rndSpwanObj], startAnker[2].transform.position, Quaternion.identity);
            bornObj.tag = "FixedObj";
        }
        //固定カウント呼び出し
        else if(SpawnNumber == 1)
        {
            int rndOccurrence = RandomOrFixedSpawn(spawnCount);

            //ランダム抽選が起きなければオブジェクト作成
            if(rndOccurrence == 0)
            {
                bornObj = Instantiate(spawnObj[rndSpwanObj], spawnPosition, Quaternion.identity);
                bornObj.tag = "FixedObj";
            }
        }
        //ランダムスポーン
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
        //カウントが2と4の時にランダム抽選
        int rndSpwanObj = 0;
        if (Count == 2 || Count == 4) rndSpwanObj = Random.Range(0, 2);

        //抽選に入らなければ固定値を設定A
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