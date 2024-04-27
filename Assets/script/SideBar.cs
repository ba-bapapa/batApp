using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.tag == "Player")
        {
            Vector3 position = collision.gameObject.transform.localPosition;

            if (collision.gameObject.transform.localPosition.x >= 0)
            {
                collision.gameObject.transform.position = new Vector3(-2.5f, position.y, position.z);
            }
            else
            {
                collision.gameObject.transform.position = new Vector3(2.5f, position.y, position.z);
            }
        }
    }
}
