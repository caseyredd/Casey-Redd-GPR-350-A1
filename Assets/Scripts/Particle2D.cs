using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle2D : MonoBehaviour
{
    public Vector3 force = Vector3.zero;
    public Vector3 acc = Vector3.zero;
    public Vector3 Damping = Vector3.Normalize(Vector3.zero);
    public Vector3 initLoc;
    public Vector3 moveLoc;
    public Vector3 vel;
    void Start()
    {

    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    void FixedUpdate()
    {
        Integrator.Integrate(vel, gameObject);
    }

}
