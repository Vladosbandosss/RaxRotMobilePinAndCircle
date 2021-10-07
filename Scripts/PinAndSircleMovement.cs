using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinAndSircleMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float upSpeed = 10f;
    bool canFly;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        canFly = true;
    }

   
    void Update()
    {
        if (canFly)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector2(0f, upSpeed);
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Circle")
        {
            canFly = false;
            rb.velocity = new Vector2(0f, 0f);
            gameObject.transform.SetParent(collision.transform);
            PinAndSircleSpaner.instance.Create();
            GameManger.instance.IncreaseScore();
        }
    }
}
