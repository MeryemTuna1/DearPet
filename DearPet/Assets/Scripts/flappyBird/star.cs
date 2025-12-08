using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{

    [SerializeField] private int value = 1;
    [SerializeField] private float speed;

    void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);

        if(transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            GameManager.Instance.AddScore(value);
            Destroy(gameObject);
        }
    }
}
