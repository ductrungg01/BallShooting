using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float moveSpeed = 2.5f;
    Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        double a = transform.rotation.eulerAngles.z;

        float x = (float)Math.Cos(a * Math.PI / 180);
        float y = (float)Math.Sin(a * Math.PI / 180);

        Vector3 angle = new Vector3( x, y, 0);

        transform.position += angle * Time.deltaTime * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            Destroy(gameObject);
        }
    }
}
