using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    private float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Y���݈̂ړ�
        float moveY = speed * Time.deltaTime;
        Vector3 newPosition = transform.position - new Vector3(0, moveY, 0);
        transform.position = newPosition;
    }
}