using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclesMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float destroyX;

    ObstacleSpawner spawner;

    private void Start()
    {
        spawner=FindObjectOfType<ObstacleSpawner>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);

        if (transform.position.x < destroyX)
        {
            // Destroy(gameObject);
            spawner.Reposition(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            GameManager.Instance.PlayerHitObstacle();  
        }
    }
}
