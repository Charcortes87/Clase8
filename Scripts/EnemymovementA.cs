using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemymovementA : MonoBehaviour
{

    [SerializeField]
    [Range(1f, 10f)]
    private float speed = 2f;
    

    
    [SerializeField] Transform playerTransform;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookPlayer();
        }
    

 
   

    
    
    private void LookPlayer()
    {
       
        Quaternion newRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
    }


}