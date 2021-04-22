using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tablerotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RandomizeYRotation();
    }

    void RandomizeMyRotation()
    {
        transform.rotation = Random.rotation;
    }

    void RandomizeYRotation()
    {
        Quaternion randYrotation = Quaternion.Euler(-90, Random.Range(-90, 90), 0);
        transform.rotation = randYrotation;
    }
}
