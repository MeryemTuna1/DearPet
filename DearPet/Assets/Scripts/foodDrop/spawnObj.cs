using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObj : MonoBehaviour
{
    [SerializeField] private GameObject[] yems;
    [SerializeField] private GameObject[] enemys;
    [SerializeField] private float spawnTime = 1.2f;
    private float minX = -2f, maxX = 2f;

    int lastIndex = -1;
    bool lastWasEnemy = false;

    private void Start()
    {
        InvokeRepeating("Spawnn",1f,spawnTime);
    }
    void Spawnn()
    {
        bool spawnEnemy = Random.Range(0,3) == 0; //%33düþman ihtimali
        int index;

        if (spawnEnemy)
        {
            do
            {
                index=Random.Range(0,enemys.Length);
            }
            while (lastWasEnemy && index  == lastIndex);

            Instantiate(enemys[index],RandomPos(), Quaternion.identity);
            lastIndex = index;
            lastWasEnemy = true;
        }
        else
        {
            do
            {
                index = Random.Range(0, yems.Length);
            }
            while (!lastWasEnemy && index == lastIndex);

            Instantiate(yems[index], RandomPos(), Quaternion.identity);
            lastIndex = index;
            lastWasEnemy = false;
        }
    }

    Vector2 RandomPos()
    {
        return new Vector2(Random.Range(minX,maxX),transform.position.y);
    }
}
