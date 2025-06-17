using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int blockLeft ;
    void Start()
    {
        //Busca los bloques en la escena y devuelve un array
       blockLeft = GameObject.FindGameObjectsWithTag("Block").Length;
    }

   public void RestartScene()
    {
        //Le pasa la escena 
        int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeSceneIndex);
    }

    public void DecreaseBlock()
    {
        blockLeft--;
        if(blockLeft == 0)
        {
            //Mandar un mensaje a consola 
           LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        //Le pasa la escena siguiente
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void QuitGame()
    {
        //Salir del juego 
        Application.Quit();
    }
}
