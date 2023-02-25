using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReWars : MonoBehaviour
{
    public int CointValue = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Gamecontroler.instance.AddScore(CointValue);
            Destroy(gameObject);
        }
    }
}
