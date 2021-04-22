using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorMaterial : MonoBehaviour
{
    public Material material;
    
    void Start()
    {
        //   material.color = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));//calling for random numbers
        // material.color = new Color32(0, 3, 255, 255); 
        material.color = new Color(Random.Range(0.3F, 0.8F), Random.Range(0.3F, 0.8F), Random.Range(0.3F, 0.8F));//calling for random numbers
    }
    
}
