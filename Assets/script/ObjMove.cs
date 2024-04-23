using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    private float _speed = 1.0f;
    private float _RotateSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, _RotateSpeed));

        //YŽ²‚Ì‚ÝˆÚ“®
        float moveY = _speed * Time.deltaTime;
        Vector3 newPosition = transform.position - new Vector3(0, moveY, 0);
        transform.position = newPosition;
    }
}