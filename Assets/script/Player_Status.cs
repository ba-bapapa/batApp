using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Status : MonoBehaviour
{
    // Start is called before the first frame update
    private float forceMagnitude = 200.0f;
    private float timer = 0.0f;
    private Rigidbody2D rb;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0) timer -= Time.deltaTime;

        if (transform.parent != null)
        {
            rb.gravityScale = 0;
            if (Input.GetMouseButtonDown(0)) MovePlayer();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (timer < 0 && collision.gameObject.tag != "Bar")
        {
            rb.bodyType = RigidbodyType2D.Static;
            this.gameObject.transform.parent = collision.gameObject.transform;
        }
    }

    private void MovePlayer()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.gravityScale = 0.2f;
        Vector3 parentToChildCenter = transform.position - transform.parent.position;
        Vector2 targetDirection = parentToChildCenter.normalized;
        transform.parent = null;
        rb.AddForce(targetDirection * forceMagnitude);
        timer = 0.1f;
    }
}