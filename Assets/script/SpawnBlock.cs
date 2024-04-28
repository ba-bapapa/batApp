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
        //ƒ‰ƒ“ƒ_ƒ€‚ÅÝ’è
        int rndSpwanObj = Random.Range(0, spawnObj.Length);
        float positionX = Random.Range(-2.0f, 2.1f);
        spawnPosition.x = positionX;

        if(SpawnNumber == 0)
        {
            bornObj = Instantiate(spawnObj[rndSpwanObj], startAnker[1].transform.position, Quaternion.identity);
            bornObj.tag = "FixedObj";
            rndSpwanObj = Random.Range(0, spawnObj.Length);
            bornObj = Instantiate(spawnObj[rndSpwanObj], startAnker[2].transform.position, Quaternion.identity);
            bornObj.tag = "FixedObj";
        }
        else if(SpawnNumber == 1)
        {
            bornObj = Instantiate(spawnObj[rndSpwanObj], spawnPosition, Quaternion.identity);
            bornObj.tag = "FixedObj";
        }

        timer = setTimer;
    }
}