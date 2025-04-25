using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UberEats : MonoBehaviour
{
    public int Stars = 0;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject , 15f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        {
            Stars += 1;
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.down * speed * Time.deltaTime;
    }
}
