using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    public GameObject[] spawnObj;
    public GameObject[] startAnker;

    private float _timer = 3.0f;
    private Vector3 _spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObj(0);
        _spawnPosition = this.gameObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            SpawnObj(1);
        }
    }

    private void SpawnObj(int SpawnNumber)
    {
        //ƒ‰ƒ“ƒ_ƒ€‚ÅÝ’è
        int rnd = Random.Range(0, spawnObj.Length);
        float positionX = Random.Range(-2.0f, 2.0f);
        _spawnPosition.x = positionX;

        if(SpawnNumber == 0)
        {
            Instantiate(spawnObj[rnd], startAnker[1].transform.position, Quaternion.identity);
            rnd = Random.Range(0, spawnObj.Length);
            Instantiate(spawnObj[rnd], startAnker[2].transform.position, Quaternion.identity);
        }
        else if(SpawnNumber == 1)
        {
            Instantiate(spawnObj[rnd], _spawnPosition, Quaternion.identity);
        }
       
        _timer = 3.0f;
    }
}