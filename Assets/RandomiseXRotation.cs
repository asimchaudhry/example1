using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomiseXRotation : MonoBehaviour
{
    void Start()
    {
        //  RandomizeMyRotation();
        RandomizeZRotation();
    }

    void RandomizeMyRotation()
    {
        transform.rotation = Random.rotation;
    }

    void RandomizeZRotation()
    {
        Quaternion randZrotation = Quaternion.Euler(0, Random.Range(0, 360), 360);
        transform.rotation = randZrotation;
    }
}
