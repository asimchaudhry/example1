using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example1 : MonoBehaviour
{
    public Vector3[] positions;

   // public Vector3[] rotation;

    void Start()
    {
        int randomNumber = Random.Range(0, positions.Length);
        transform.position = positions[randomNumber];

      //  int randomRotation = Random.Range(0, rotation.Length);
      //  transform.rotation = Quaternion.Euler(0, 0, 0);

    }
}
