using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnvrmntController : MonoBehaviour
{
    /// <summary>
    ///  script for realass manz 
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetTouch(0).phase != TouchPhase.Moved)
            transform.rotation =Quaternion.Slerp(transform.rotation, Quaternion.identity, 0.01f);

    }
}
