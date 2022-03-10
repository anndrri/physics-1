using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public float velocity;
    public float Timer;
    public float TimerMax;
    public float Radius;
    public Rigidbody[] rigidbodies;
    void Start()
    {
        Timer = TimerMax;
    }
    void Update()
    {
        Timer = Timer - Time.deltaTime;
        if (Timer <= 0)
        {
            Explosion();
            Timer = TimerMax;
        }
    }
    public void Explosion()
    {
        rigidbodies = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody i in rigidbodies)
        {
            if (Vector3.Distance(transform.position, i.transform.position) < Radius)
            {
                Vector3 Direction = i.transform.position - transform.position;
                i.AddForce(Direction.normalized * velocity * (Radius - Vector3.Distance(transform.position, i.transform.position)), ForceMode.Impulse);
            }
        }
    }
}
