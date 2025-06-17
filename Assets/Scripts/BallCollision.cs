using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    GameManager gameManager;

    void Start()
    {
        // Busca el objeto GameManager en la escena
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            //Acceder al objeto que colisiona con la pelota
            Destroy(collision.gameObject);
            gameManager.DecreaseBlock();
        }

    }

    private  void OnTriggerEnter2D()
    {
     gameManager.RestartScene();   
    }
}
