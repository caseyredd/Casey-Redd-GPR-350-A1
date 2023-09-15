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
    static public void Integrate(Vector3 vel, GameObject obj)
    {
        if (obj.transform.position != obj.GetComponent<Particle2D>().moveLoc)
        {
            obj.transform.position = obj.transform.position + vel * Time.deltaTime;
        }
        if (obj.transform.position == obj.GetComponent<Particle2D>().moveLoc)
        {
            Destroy(obj);
        }
    }

}
