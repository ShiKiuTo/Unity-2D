using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// di chuyển một khoảng cách
public class Dichuyenvatcan : MonoBehaviour
{
    public float speed = 40;
    private bool canMove = false;

    private void Update()
    {
        if (canMove)
        {
            GetComponent<Rigidbody2D>().velocity =
                new Vector2(transform.localScale.x, 0) * speed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        canMove = collision.gameObject.tag == "Ground";
    }
}
