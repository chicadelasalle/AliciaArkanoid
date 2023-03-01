using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Velocidad de la pelota
    public float speed = 25;

    //Referencia a la posicon inicial de la pelota
    public Vector2 ballInit;

    // Start is called before the first frame update
    void Start()
    {   //La bola se mueve hacia arriba
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
       
        //Vector2.left = new Vector2(-1, 0)
        //Reco
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /* Metodo de Unity, siempre hay que ponerlo en privado, y detecta la colision entre dos game objects
     * Al chocar el objeto contra el que choca le pasa su colision por parametros.
     * 
     * Solo funciona si el objeto que colisiona y donde colisiona tiene un collider.
    -El objeto collision del parentesis contiene la informacion del choque (es el objeto que ha chocado, con el que lleva el codigo)
    -En particular nos interesa saber cuando choca con una pala.
    -colision.GameObject: tiene informacion del objeto contra el cual he colisionado.
    -collision.transform.position: tiene informacion de la posicion de ese objeto.
    -collision.collider: tiene informacion del collider del objeto
     */ 

    private void OnCollisionEnter2D(Collision2D collision)
    {   //Si la pelota ha colisionado con la pala izquierda
        if (collision.gameObject.name == "Racket")
        {//Obtenemos el factor de golpeo, pasandole la posicion de la pelota, la posicion de la pala,y lo que mide de ancho el collider de la pala( es decir lo que mide la pala)

            float xF = HitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);
            /*Le damos una nueva direccion a la pala, en este caso con una Y hacia arriba
             * Y nuestro factor de golpeo calculado
             * Normalizado todo el vector a 1, para que la bola no acelere*/
            Vector2 direction = new Vector2(xF, 1).normalized;
            //Le decimos a la bola que salga con esa velocidad, previamente calculada.

            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }


        
    }


    /* 1- La bola choca contra la parte derecha de la raqueta
     * 0- La bola choca contra el centro de la raqueta
     * -1- La bola choca contra la parte izquierda de la raqueta
     */
    /* Es un metodo de tipo 3. En este caso le pasamos 3 parametros:
     * - Posicion actual de la pelota
     * - Posicion actual de la pala
     * - Ancho de la pala
     * Y el metodo, tal y como le indiamos nos devuelve una variable de tipo float*/
    /* Se resta el valor del centro de la pelota, menos el centror de la barra y el resultado se divide por la altura de la barra
     */
    private float HitFactor(Vector2 ballPosition, Vector2 racketPosition, float racketWidht)
    {
        return (ballPosition.x - racketPosition.x) / racketWidht;
    }

    //Metodo para resetear la pelota
    public void ResetBall()
    { //paramos la velocidad de la pelota
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //Ponemos la pelota en su posicion inicial
        transform.position = ballInit;

        //Si aun nos quedan vidas restantes, reseteamos
        if (GameManager.sharedInstance.lives > 0)
        {
            //Esperamos unos segundos y volvemos a decirle a la bola 
        }
    }
        //Metodo para relanzar la bola

        private void ResetBallMovements()


    

}
