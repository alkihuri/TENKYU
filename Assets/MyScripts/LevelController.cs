using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    GameObject Envrt;
    float horizonta, vertical;
    // Start is called before the first frame update
    void Start()
    {
        Envrt = GameObject.FindGameObjectWithTag("Environment");
    }

    // Update is called once per frame
    void Update()
    {
        horizonta = Input.GetAxis("Mouse Y");
        vertical = Input.GetAxis("Mouse X");
        Envrt.transform.Rotate(horizonta, horizonta, 0);
    }
}
