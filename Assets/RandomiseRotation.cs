using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseRotation : MonoBehaviour
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
        Quaternion randYrotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
        transform.rotation = randYrotation;
    }

}
