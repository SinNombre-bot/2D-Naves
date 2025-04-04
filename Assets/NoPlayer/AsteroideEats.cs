using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroideEats : MonoBehaviour
{
    public float spawnRate;
    public float spawnInterval;
    public GameObject asteroide;
    public Transform BorderLeft;
    public Transform BorderRight;

 
    void Start()
    {
        
    }

 
    void Update()
    {
        spawnRate -= Time.deltaTime;
        if(spawnRate <= 0)
        {
            Spawn();
        }
    }
    void Spawn()
    {
        float randomX = Random.Range(BorderLeft.position.x, BorderRight.position.x);

        Vector2 newPosition = transform.position;
        newPosition.x = randomX;

        Instantiate(asteroide, newPosition, Quaternion.identity);
        spawnRate = spawnInterval;
    }
}
