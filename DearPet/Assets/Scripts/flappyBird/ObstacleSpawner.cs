using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Transform spawnPos1,spawnPos2;
    [SerializeField] private GameObject[] preafabs;
    [SerializeField] private float yRange=2.5f;

    int lastA=-1, lastB=-1;
    List<obstaclesMovement> active=new List<obstaclesMovement>();

    void Start()
    {
        for (int i = 0; i <= preafabs.Length; i++)
        {
            SpawnInitial(i);
        }
    }

    void SpawnInitial(int i)
    {
        Transform point = (i%2==0) ? spawnPos1: spawnPos2;
        bool isA = point == spawnPos1;

        int idx = PickDifferent(isA);

        Vector3 pos = point.position;
        pos.y += Random.Range(-yRange,yRange);
        pos.x += i * 3.5f;

        GameObject obj = Instantiate(preafabs[idx],pos,Quaternion.identity);
        active.Add(obj.GetComponent<obstaclesMovement>());

        if (isA) lastA = idx; else lastB = idx;
    }
  
    int PickDifferent(bool isA)
    {
        int last= isA ? lastA : lastB;
        int idx;

        do
        {
            idx = Random.Range(0,preafabs.Length);
        }
        while (idx==last);
        return idx;
    }

    public void Reposition(obstaclesMovement obs)
    {
        Transform point=Random.value<0.5f?spawnPos1 : spawnPos2;
        bool isA=point == spawnPos1;

        int idx = PickDifferent(isA);

        obs.transform.position = new Vector3(
            point.position.x,
            point.position.y+Random.Range(-yRange,yRange),
            0
            );

        obs.transform.position += Vector3.right * Random.Range(2f,5f);

        if(isA)  lastA=idx; else lastB=idx;
    }

}
