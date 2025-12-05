using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementRL : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    [SerializeField] private float limitX = 7;

    private float firstTouchX;
    private bool isTouching=false;

    void Start()
    {
        
    }

    
    void Update()
    {


        float solsag = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * solsag * speed * Time.deltaTime);

        TouchControl();


        /*float solsag = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right*solsag*speed*Time.deltaTime);*/

        float x = Mathf.Clamp(transform.position.x,-limitX,limitX);
        transform.position = new Vector2(x,transform.position.y);
    }

    void TouchControl()
    {
        if (Input.touchCount>0)
        {
            Touch touch=Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                firstTouchX = touch.position.x;
                isTouching = true;
            }
            else if(touch.phase==TouchPhase.Moved && isTouching)
            {
                 float deltaX=touch.position.x - firstTouchX;
                 float move = deltaX * speed * Time.deltaTime * 0.02f;

                transform.Translate(Vector2.right*move);

                firstTouchX=touch.position.x;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isTouching=false;
            }
        }
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
