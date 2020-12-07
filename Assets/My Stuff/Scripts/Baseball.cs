using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baseball : MonoBehaviour
{
    private AudioSource audio;
    private bool hit;
    Rigidbody rb;
    public float gravity;
    public Vector3 myCurrentSpeed;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        rb = gameObject.GetComponent<Rigidbody>();
        Destroy(gameObject, 15);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 0)
        {
            Destroy(gameObject);
        }
        rb.AddForce(Vector3.down * gravity);
    }

    private void FixedUpdate()
    {
        myCurrentSpeed = rb.velocity;
    }

    public void ballHit(Vector3 batSpeed)
    {
        if(!hit)
        {
            gravity = 8;
            rb.velocity = batSpeed;
            audio.Play();
            Manager.Instance.updateBall(rb);
            GetComponent<TrailRenderer>().enabled = true;
            hit = true;
        }
    }

}
