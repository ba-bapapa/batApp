using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Status : MonoBehaviour
{
    // Start is called before the first frame update
    private float forceMagnitude = 200.0f;
    private float _timer = 0.5f;
    Rigidbody2D rb;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_timer > 0) _timer -= Time.deltaTime;

        if (transform.parent != null)
        {
            rb.gravityScale = 0;

            if (Input.GetMouseButtonDown(0)) MovePlayer();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(_timer <= 0 && collision.gameObject.tag != "Bar")
        {
            this.gameObject.transform.parent = collision.gameObject.transform;
        }
    }

    private void MovePlayer()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.2f;
        Vector3 parentToChildCenter = transform.position - transform.parent.position;
        Vector2 targetDirection = parentToChildCenter.normalized;
        transform.parent = null;
        rb.AddForce(targetDirection * forceMagnitude);
        _timer = 0.5f;
    }
}