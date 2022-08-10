using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemymovementB : MonoBehaviour
{

    [SerializeField]
    [Range(1f, 10f)]
    private float speed = 2f;
    

    //Guardamos una referencia al transform del player para movernos en su dirección.
    [SerializeField] Transform playerTransform;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChasePlayer();
        }
    

 
   

    
    
   private void ChasePlayer()
    {
        LookPlayer();
        // Con la resta vectorial obtengo la dirección que me permite desplazarme hacia el player.
        Vector3 direction = (playerTransform.position - transform.position);
        // Uso la magnitude para avanzar solo hasta cierta distancia (y no superponer el enemigo)
        if (direction.magnitude > 2f)
        {
           // Uso normalized para trasformar el vector en un vector de magnitud uno (para avanzar de forma gradual y constante cada frame)
           transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }
        private void LookPlayer()
    {
        // Método para rotar "inmediatamente" hacia un trasform.
        //transform.LookAt(playerTransform);
        // Forma para rotar "gradualmente" hacia un trasform.
        Quaternion newRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
    }
}