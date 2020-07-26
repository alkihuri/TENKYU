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
        
        speedOfRotation =0.0999f;
       
    }

    // Update is called once per frame
    void Update()
    {
        Envrt = GameObject.FindGameObjectWithTag("Environment");


#if UNITY_EDITOR

        horizontal = Input.GetAxis("Mouse Y");
        vertical = Input.GetAxis("Mouse X"); 

#endif

#if UNITY_ANDROID
       horizontal = -Input.GetTouch(0).deltaPosition.x;
       vertical = -Input.GetTouch(0).deltaPosition.y;
#endif
        if (Mathf.Abs(Envrt.transform.rotation.x) < 15)
            newX = horizontal * speedOfRotation;
        else
            newX = 0;
        if (Mathf.Abs(Envrt.transform.rotation.z) < 15)
            newZ = vertical * speedOfRotation;
        else
            newZ = 0;

        
        Envrt.transform.Rotate(newX, 0, newZ);
    }
   
}
