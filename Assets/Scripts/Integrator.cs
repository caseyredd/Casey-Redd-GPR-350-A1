using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Integrator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    static void Integrate(Vector3 vel, Vector3 movePos)
    {
        if (gameObject.transform.pos != movePos)
        {
            transform.pos = gameObject.transform.position + vel * Time.deltaTime;
        }
    }
}
