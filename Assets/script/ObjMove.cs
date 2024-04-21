using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    private float speed = 1.0f;
    private Vector3 thisGmaeObj;

    // Start is called before the first frame update
    void Start()
    {
        thisGmaeObj = this.gameObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //YŽ²‚Ì‚ÝˆÚ“®
        float moveY = speed * Time.deltaTime;
        Vector3 newPosition = transform.position - new Vector3(0, moveY, 0);
        transform.position = newPosition;
    }
}