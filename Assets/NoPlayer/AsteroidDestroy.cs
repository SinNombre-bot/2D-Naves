using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroy : MonoBehaviour
{

    void Start()
    {
        Destroy(this.gameObject, 30f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Destruyeasteroides") || collision.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }

}
