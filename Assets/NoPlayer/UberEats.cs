using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UberEats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject , 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.down * Time.deltaTime;
    }
}
