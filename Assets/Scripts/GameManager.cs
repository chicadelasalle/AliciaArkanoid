using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //Libreria para la interfaz de Unity

public class GameManager : MonoBehaviour
{

    //referencia para la imagenes de las vidas
    public Image live1, life2, life3;
    //Iniciamos el contador de vidas
    public int lives = 3;

    //hacmemos un Singleton el script Game Manager para poder usar sus propiedad desde todas las scripts

    public static

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //Controlamos las imagenes de las vidas, dependiendo de cuantas nos quedan
        //Si nos quedan menos de 3 vidas
        if(lives < 3)
        {
            //Desactivamos la imagen de la vida 3
            live3.enable = false; //Enable dete desactiva  un componente de un GO
        }
        if (lives < 2)
        {
            //Desactivamos la imagen de la vida 2
            live2.enable = false; 
        }
        if (lives < 1)
        {
            //Desactivamos la imagen de la vida 1
            live1.enable = false;
        }
        //Nos damos cuenta de que al ver el valor de una sola variable, podemos cambiarlo por un switch*/


        switch (lives)
        {
            case 3:
                //Activamos la imagen de la vida 3
                lived3.enabled = true;
                //Activamos la imagen de la vida 2
                lived2.enabled = true;
                //Activamos la imagen de la vida 1
                lived1.enabled = true;
                break;

            //En el caso de que las vidas sean 2
            case 3:
                //Activamos la imagen de la vida 3
                lived3.enabled = true;
                //Activamos la imagen de la vida 2
                lived2.enabled = true;
                //Activamos la imagen de la vida 1
                lived1.enabled = true;
                break;
        }
            
        //Vamos a contarcuantos bloques hay en esta partid
        //Cremos un array donde meter todos los bloques 
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("Block");
        //FindGameObjetcsWithTag busca game objects por etiqueta
        //Si el tamaño del array es 0,osea se ha quedado vacio, no quedan bloques

        if(blocks.Length == 0)
        {
            //Invocamos al metodo para hacer el cambio de escena en 2 seg
            Invoke("GoToNextScene", 2.0f);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Exit game");
            //Esto apaga el juego
            Application.Quit();
        }

    }

    //Metodo para cambiar escenas
    private void GoToNextScene()
    { //Cambiamos de escena yendo a la siguiente que tengamos preparada en la Build Settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Build Index es el numero de la escena actual en los Build Settings
    }
}

