using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pallo : MonoBehaviour
{
    Rigidbody2D rb;

    public float pomppuVoima;

    bool gameStarted;

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
        if (!gameStarted)
        {
            if (Input.anyKeyDown)
            {
                StartPomppu();
                gameStarted = true;
                GameManager.instance.GameStart();
            }
        }


    }

    void StartPomppu()
    {
        // satunnainen suunta X välillä -1 ja 1, Y on vakio 1
        Vector2 randomDirection = new Vector2(Random.Range(-1f, 1f), 1);
                

        // annetaan Pallolle vauhtia pomppuVoiman verran  satunnaiseen randomDirection -suuntaan
        //valitaan vauhdin muodoksi impulssi
        rb.AddForce(randomDirection * pomppuVoima, ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FallCheck")
        {
            GameManager.instance.Restart();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag ==  "Maila")
        {
            GameManager.instance.ScoreUp();
        }          
        
    }



}
