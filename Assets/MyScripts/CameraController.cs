using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player, camera;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        camera = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = Vector3.Slerp(camera.transform.position, new Vector3(-25, player.transform.position.y + 20, player.transform.position.z), 0.5f);
        camera.transform.LookAt(player.transform.position);
        camera.GetComponent<Camera>().fieldOfView = 60 + player.GetComponent<Rigidbody>().velocity.magnitude * 2;
    }
}
