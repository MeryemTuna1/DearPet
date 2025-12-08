using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementBird : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }


        if(Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Began)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Obstacles")
        {
           GameManager.Instance.PlayerHitObstacle();
        }
    }
}
