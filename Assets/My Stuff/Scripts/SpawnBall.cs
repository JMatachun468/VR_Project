using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public Transform ballSpawn;
    public Rigidbody baseball;
    public float speed;


    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ThrowBall();
        }
    }

    public void ThrowBall()
    {
        Rigidbody projectile;
        projectile = Instantiate(baseball, ballSpawn, false);
        projectile.velocity = Vector3.back * speed;

        Debug.Log("ball spawned");
    }
}
