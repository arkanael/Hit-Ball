using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody2D ball;

    [SerializeField]
    private float bounceForce;

    private bool isMoving; 

    private void Awake()
    {
      
    }

    // Start is called before the first frame update


    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        bounceForce = GameManager.instance.ballBounceForce;
    }

    // Update is called once per frame
    void Update()
    {
        IsMoving();
    }


    void StartBounce()
    {
        float[] index = { -3, -2, -1, 1, 2, 3, 4 };
        Vector2 ramdomDirection = new Vector2(UnityEngine.Random.Range(index[0], index.Count()), 1); ;

        ball.AddForce(ramdomDirection * bounceForce, ForceMode2D.Impulse);
    }

    private void IsMoving()
    {
        if (!isMoving)
        {
            if (Input.anyKeyDown)
            {
                StartBounce();
                isMoving = true;
                GameManager.instance.GameStart();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "FallCheck")
        {
            GameManager.instance.Restart();
        }

        if (collision.gameObject.tag == "Paddle")
        {
            GameManager.instance.ScoreUp();

        }
    }
}
