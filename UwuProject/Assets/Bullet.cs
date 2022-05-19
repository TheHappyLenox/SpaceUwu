using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    int dir = 1;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void ChangeDirection()
    {
        dir *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0,20 * dir);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "tag autre")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "tag enemy")
        {
            col.gameObject.GetComponent<Enemy>().Damage();
            Destroy(gameObject);
        }
    }
}
