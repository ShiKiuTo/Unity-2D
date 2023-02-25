using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthFly : MonoBehaviour
{
    public float speed = 0.5f;
    public float maxDistance = 30;
    private Rigidbody2D rbg;
    private float distance = 0;
    void Start()
    {
        rbg = GetComponent<Rigidbody2D>();
        distance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime * 2;
        if (distance > maxDistance)
        {
            transform.localScale = new Vector2(-transform.localScale.x, 
                transform.localScale.y);
            distance = 0;
        }
        rbg.velocity = new Vector2(-transform.localScale.x, 0) * speed;
    }
}
