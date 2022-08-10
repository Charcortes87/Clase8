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
       
        Vector3 direction = (playerTransform.position - transform.position);
       
        if (direction.magnitude > 2f)
        {
       
           transform.position += direction.normalized * speed * Time.deltaTime;
        }
    }
        private void LookPlayer()
    {
       
        Quaternion newRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
    }
}