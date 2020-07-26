using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampTwoManager : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameStates.score++;
        }
    }
}
