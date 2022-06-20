using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstaculos_Script : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.R))
      {
        ReiniciarPartida();
      }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstaculo") 
        {
            Time.timeScale = 0f;
        }
    }
    private void ReiniciarPartida() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
