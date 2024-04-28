using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    private float yMoveSpeed = 1.0f;
    private float rotateSpeed = 0.11f; //回転速度は＋１で設定する
    private float lowestRotateSpeed = 0.01f;
    private float rndRotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        int rndDirectionRotate = Random.Range(0, 2);
        if (rndDirectionRotate == 0) rndRotateSpeed = Random.Range(lowestRotateSpeed, rotateSpeed);
        else rndRotateSpeed = Random.Range(lowestRotateSpeed * -1, rotateSpeed * -1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rndRotateSpeed));

        //Y軸のみ移動
        float moveY = yMoveSpeed * Time.deltaTime;
        Vector3 newPosition = transform.position - new Vector3(0, moveY, 0);
        transform.position = newPosition;
    }
}