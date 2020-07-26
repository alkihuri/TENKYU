using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnvrmntController : MonoBehaviour
{
    public GameObject envrmnt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").transform.SetParent(null);
           GameObject.FindGameObjectWithTag("Player").transform.SetParent(Instantiate(envrmnt, GameObject.FindGameObjectWithTag("Player").transform.position - new Vector3(0, 6, 0), Quaternion.identity).transform);
            Destroy(gameObject);
            GameStates.level++;
            if(GameStates.score%2==1)
            {
                SceneManager.LoadScene("Finish");
            }
        }
        

    }
}
