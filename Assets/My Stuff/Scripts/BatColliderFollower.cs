using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatColliderFollower : MonoBehaviour
{
    private GameObject _batFollower;
    private Rigidbody rb;
    private Vector3 _velocity;

    [SerializeField]
    private float _sensitivity = 50f;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        Vector3 destination = _batFollower.transform.position;
        rb.transform.rotation = transform.rotation;

        _velocity = (destination - rb.transform.position) * _sensitivity;

        rb.velocity = _velocity;
        transform.rotation = _batFollower.transform.rotation;
    }

    public void setFollowTarget(GameObject batFollower)
    {
        _batFollower = batFollower;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Baseball>())
        {
            Debug.Log(other.gameObject.name + ": " + other.gameObject.GetComponent<Rigidbody>().velocity);
            Debug.Log(name + ": " + rb.velocity);

            other.GetComponent<Baseball>().ballHit(rb.velocity);
        }
    }
}
