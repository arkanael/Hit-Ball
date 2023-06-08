using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    Rigidbody2D paddle;

    private float moveSpeed;

    private void Awake()
    {
        paddle = GetComponent<Rigidbody2D>();
        moveSpeed = GameManager.instance.paddleMoveSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        TouchMove();
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPosition.x < 0)
            {
                paddle.velocity = (Vector2.left * moveSpeed) * Time.deltaTime ;
            }
            else
            {
                paddle.velocity = (Vector2.right * moveSpeed) * Time.deltaTime;
            }
        }
        else
        {
            paddle.velocity = Vector2.zero;
        }
    }

    public void PlayerMovimentando()
    {
        //Retorna o valor calculado entre -1 e 1 para saber para onde o player esta querendo se mover
        float xInput = Input.GetAxis("Horizontal");

        //A velocidade Final é calculada pela variavel variavel X o input [-1 ou 1] X um vetor right para dar uma direção a velocidade
        //velocidadeHorizontal = velocidadeJogador * xInput * Vector2.right;

        ////A velocidade vertificar final recebe a propria velocidade somando pela gravidade multiplicada pelo vetor down multiplicada pelo delta time.
        //velocidadeVertical += (velocidadeJogador * Time.deltaTime * Vector2.down);

        ////Velocidade final sendo a soma da velocidade vertical e da velocidade horizontal
        //velocidadeFinal = velocidadeVertical + velocidadeHorizontal;

        ////Movimentar
        //characterController.Move(velocidadeFinal * Time.deltaTime);
    }
}
