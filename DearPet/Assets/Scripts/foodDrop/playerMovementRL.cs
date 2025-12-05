using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementRL : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    [SerializeField] private float limitX = 7;

    void Start()
    {
        
    }

    
    void Update()
    {
        float solsag = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right*solsag*speed*Time.deltaTime);

        float x = Mathf.Clamp(transform.position.x,-limitX,limitX);
        transform.position = new Vector2(x,transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Yem"))
        {
            canManager.instance.AddScore(1);
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Finish"))
        {
            canManager.instance.LoseLife();
            Destroy(collision.gameObject);
        }

    }
}
