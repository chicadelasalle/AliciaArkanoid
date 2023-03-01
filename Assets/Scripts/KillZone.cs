using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
        if(collision.gameObject.CompareTag("Ball"))
        {
         //Le quitamos una vida al jugador
         GameManager.sharedInstance.lives--;
        //Desactivamos la pelota
        collision.gameObject.SetActive(false);
        }

    //Metodo para saber cuando la pelotase ha metido en la zona 
}
