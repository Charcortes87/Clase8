using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBala : MonoBehaviour
{
    
    public Vector3 direction = new Vector3(0f, 0f, 1f); 
    public float speed = 2f;
    public float tiempoDeVida = 2f;

    public Vector3 tamaño = new Vector3(2f, 1f, 1f);
     
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyDelay", tiempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(Input.GetKeyDown(KeyCode.Space))
        {transform.localScale = tamaño;
        }
    }
 
        
    
        private void Move()
    {
        transform.position +=direction * speed * Time.deltaTime;
    }
     private void DestroyDelay()
     {
        Destroy(gameObject);
     }
}
