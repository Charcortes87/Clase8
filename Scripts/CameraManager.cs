using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject [] Cameras;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Cameras[0].SetActive(true);
            Cameras[1].SetActive(false);
        }
              if(Input.GetKeyUp(KeyCode.P))
        {
            Cameras[0].SetActive(false);
            Cameras[1].SetActive(true);
        }
    }
}
