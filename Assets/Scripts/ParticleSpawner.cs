using JetBrains.Annotations;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public GameObject particlePrefab;
    Vector3 initLoc;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            initLoc = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 moveLoc = Input.mousePosition;
            Vector3 vel = moveLoc - initLoc;
            GameObject newObject = GameObject.Instantiate(particlePrefab, initLoc, Quaternion.identity);
            newObject.GetComponent<Particle2D>().moveLoc = moveLoc;
            newObject.GetComponent<Particle2D>().vel = vel;
        }
    }
}
