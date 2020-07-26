using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    GameObject Envrt;
    float horizontal =0 , vertical = 0;
    float newX, newZ;
    [SerializeField, Range(0, 1)] float speedOfRotation;
    // Start is called before the first frame update
    void Start()
    {
        
        speedOfRotation =0.04f;
       
    }

    // Update is called once per frame
    void Update()
    {
        Envrt = GameObject.FindGameObjectWithTag("Environment");
        /*
       horizontal = Input.GetAxis("Mouse Y") ;
       vertical = Input.GetAxis("Mouse X") ;
       */
        horizontal = -Input.GetTouch(0).deltaPosition.x;
        vertical = -Input.GetTouch(0).deltaPosition.y;
        newX =   horizontal * speedOfRotation;
        newZ =  vertical * speedOfRotation;
        Envrt.transform.Rotate(newX, 0, newZ);
    }
   
}
