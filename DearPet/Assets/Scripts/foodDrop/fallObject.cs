using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallObject : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        transform.Translate(Vector2.down*speed*Time.deltaTime);
         if (transform.position.y<-10f)
         {
            Destroy(gameObject);
         }
    }
}
