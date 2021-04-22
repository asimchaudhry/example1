using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvpickitem : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;


    void Start()
    {
        Pick();
    }

    void Pick()
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], transform.position, transform.rotation);

    }
}



// , transform.position, Quaternion.identity