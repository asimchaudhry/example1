using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public GameObject[] itemsToPickFrom;
    

    void Start()
    {
        Pick();
    }

    void Pick()
    {
        int randomIndex = Random.Range(0, itemsToPickFrom.Length);
        GameObject clone = Instantiate(itemsToPickFrom[randomIndex], transform.position, Quaternion.identity);

    }
}



// , transform.position, Quaternion.identity





/* public Vector3[] positions;
void Start()
{
    int randomNumber = Random.Range(0, positions.Length);
    transform.position = positions[randomNumber];
}

*/