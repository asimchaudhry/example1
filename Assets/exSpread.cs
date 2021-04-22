using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exSpread : MonoBehaviour
{
    public GameObject itemToSpread;
    public GameObject itemToSpread2;
    public GameObject itemToSpread3;
    public GameObject itemToSpread4;



    public float itemXSpread = 10;
    public float itemYSpread = 0;
    public float itemZSpread = 10;

    void Start()
    {

        SpreadItem();
        SpreadItem2();
        SpreadItem3();
        SpreadItem4();
    }

    void SpreadItem()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
        GameObject clone = Instantiate(itemToSpread, randPosition, Quaternion.identity);
    }

    void SpreadItem2()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
        GameObject clone = Instantiate(itemToSpread2, randPosition, Quaternion.identity);
    }

    void SpreadItem3()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
        GameObject clone = Instantiate(itemToSpread3, randPosition, Quaternion.identity);
    }

    void SpreadItem4()
    {
        Vector3 randPosition = new Vector3(Random.Range(-itemXSpread, itemXSpread), Random.Range(-itemYSpread, itemYSpread), Random.Range(-itemZSpread, itemZSpread)) + transform.position;
        GameObject clone = Instantiate(itemToSpread4, randPosition, Quaternion.identity);
    }
}
