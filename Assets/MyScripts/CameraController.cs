﻿using System.Collections;
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
        camera.transform.position = new Vector3(-10, player.transform.position.y, player.transform.position.z);
    }
}