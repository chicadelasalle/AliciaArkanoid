using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovements : MonoBehaviour
{
    //Velocidad de la raqueta
    public float racketSpeed = 25;
        //Eje que quiero usar para esta pala
    public string axis = "Horizontal";

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Ponemos FixedUpdate para que la longitud de cada frame en segundos mida lo mismo y asi el movimiento sea suavizado
    void FixedUpdate()
    {
        //Para poder acceder a ese componente
        //Obtenemos el valor del eje asignado
        float h = Input.GetAxis(axis);

        //Debut.Log(h);
        //Accedemos al componente de Rigidbody del objeto donde esta metido el scrip y le aplicamos una velocidad en x
        GetComponent<Rigidbody2D>().velocity = new Vector2(h, 0) * racketSpeed;//Multiplicamos por la velocidad de movimiento => 1*25 ó -1.25
    }
}
