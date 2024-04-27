using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Status : MonoBehaviour
{
    // Start is called before the first frame update
    private float _speed = 3.0f;
    private float _timer = 0.5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_timer > 0) 
        {
            _timer -= Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0) && transform.parent != null)
        {
            Vector3 parentToChildCenter = transform.position - transform.parent.position;
            transform.parent = null;
            GetComponent<Rigidbody2D>().velocity = parentToChildCenter.normalized * _speed;
            _timer = 0.5f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(_timer <= 0 && collision.gameObject.tag != "Bar")
        {
            this.gameObject.transform.parent = collision.gameObject.transform;
        }
    }
}