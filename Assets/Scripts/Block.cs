using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Block : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    /*Metodo para saber cuando choca contra el bloque en nuestro caso el unico objeto que se mueve por la pantalla es la bola, luego solamente puede ser ella la que choque contra los bloques*/

    private void OnCollisionEnter2D(Collision2D collision)
    
 { 
        if(collision.gameObject.CompareTag("Ball"))
    {
        //Destruios el objeto contra el que choca la pelota

        Destroy(this.gameObject);
    }
  }
}
