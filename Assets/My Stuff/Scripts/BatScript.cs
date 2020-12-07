using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
public class BatScript : MonoBehaviour
{
    public Vector3 myCurrentSpeed;
    public bool isGrabbed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        myCurrentSpeed = gameObject.GetComponent<Rigidbody>().velocity;
    }

    public void Grabbed()
    {
        isGrabbed = true;
    }

    public void Dropped()
    {
        isGrabbed = false;
    }
}
