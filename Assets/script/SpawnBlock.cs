using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    public GameObject[] spawnObj;

    private float _timer = 3.0f;
    private Vector3 _spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        _spawnPosition = this.gameObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("aa");
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            //ランダムで設定
            int rnd = Random.Range(0, spawnObj.Length);
            float positionX = Random.Range(-2.0f, 2.0f);
            _spawnPosition.x = positionX;

            //オブジェクト作成
            Instantiate(spawnObj[rnd], _spawnPosition, Quaternion.identity);
            _timer = 3.0f;
        }
    }
}