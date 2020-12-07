using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manager : MonoBehaviour
{
    public TextMeshPro distanceText;
    private static Manager _instance;
    public GameObject PitchMachine;
    public float ballTimer;
    public float countdown;
    private Rigidbody myBall;

    public static Manager Instance { get { return _instance; } }

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0)
        {
            ThrowBall();
            countdown = ballTimer;
        }
        else
        {
            countdown -= Time.deltaTime;
        }

        Distance(myBall);
    }

    void ThrowBall()
    {
        PitchMachine.GetComponent<SpawnBall>().ThrowBall();
    }

    public void Distance(Rigidbody baseball)
    {
        Rigidbody ball = baseball;
        float ballDistance = Vector3.Distance(gameObject.transform.position, ball.transform.position);

        distanceText.text = "Distance: " + (Mathf.Round(ballDistance * 100f) /100f) + "\n" + "Velocity: " + (Mathf.Round(ball.velocity.magnitude * 100f) / 100f);
    }

    public void updateBall(Rigidbody ball)
    {
        myBall = ball;
    }
}
