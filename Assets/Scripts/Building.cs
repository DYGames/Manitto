using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public int id;

    void Start()
    {
        id = Random.Range(1, 11);
    }
    
    void UpdatePeriod()
    {
        transform.position = new Vector3();
    }

}
