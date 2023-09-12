using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle2D : MonoBehaviour
{
    void Start()
    {
        Vector3 initLoc = gameObject.pos;
        Vector3 moveLoc = gameObject.pos;
        Vector3 vel = gameObject.pos;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 initLoc = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 moveLoc = Input.mousePosition;
            Vector3 vel = moveLoc - initLoc;
        }
    }

    void FixedUpdate()
    {
        gameObject.GetComponent<Integrator>.Integrate(Vector3 vel, Vector3 moveLoc);
    }

}
