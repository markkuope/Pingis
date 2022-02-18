using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maila : MonoBehaviour
{
    Rigidbody2D rb;

    public float nopeus;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        TouchMove();
    }

    void TouchMove()
    {
        if(Input.GetMouseButton(0)) // kun painetaan hiiren vasenta näppäintä
{
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(touchPos.x < 0)
{
                // move left
                rb.velocity = Vector2.left * nopeus;
            }else
            {
                // move right
                rb.velocity = Vector2.right * nopeus;
            }
        }
        else
        {
            rb.velocity = Vector2.zero; // kun hiiri ei kosketa ruutua, vauhti pysähtyy
        }
    }
}
