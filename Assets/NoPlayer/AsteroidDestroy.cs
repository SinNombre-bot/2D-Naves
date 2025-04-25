using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidDestroy : MonoBehaviour
{

    void Start()
    {
        Destroy(this.gameObject, 30f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            Destroy(collision.gameObject);
            StartCoroutine(DestroyRoutine());
        }
        if (collision.CompareTag("Destruyeasteroides") || collision.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
            if (collision.CompareTag("Bullet")) 
            {
                Destroy(collision.gameObject);
            }
        }
        
    }
    private IEnumerator DestroyRoutine()
    {
        yield return null;
        SceneManager.LoadScene(1);
    }

}
