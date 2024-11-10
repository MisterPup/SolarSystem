using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotation : MonoBehaviour
{
    public float tumble; //random initial rotation

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody> ().angularVelocity = Random.insideUnitSphere * tumble; //random 3d rotation
    }

}
