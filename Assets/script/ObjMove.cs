using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    private float yMoveSpeed = 1.0f;
    private float rotateSpeed = 0.11f; //âÒì]ë¨ìxÇÕÅ{ÇPÇ≈ê›íËÇ∑ÇÈ
    private float lowestRotateSpeed = 0.05f;
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

        //Yé≤ÇÃÇ›à⁄ìÆ
        float moveY = yMoveSpeed * Time.deltaTime;
        Vector3 newPosition = transform.position - new Vector3(0, moveY, 0);
        transform.position = newPosition;
    }
}