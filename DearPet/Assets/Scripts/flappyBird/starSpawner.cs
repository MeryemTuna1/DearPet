using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSpawner : MonoBehaviour
{

    [SerializeField] private GameObject preafabStar;
    [SerializeField] private Transform pos;

    void Start()
    {
        InvokeRepeating("starSpawn", 5f,5f);
    }

    
    void starSpawn()
    {
        Vector3 pos1 = pos.position;
        pos1.y = Random.Range(-3f,3f);
        Instantiate(preafabStar,pos1,Quaternion.identity);
    }
}
