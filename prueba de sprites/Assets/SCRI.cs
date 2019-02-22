using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class SCRI : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (CrossPlatformInputManager.GetButton("juego"))
        {

            SceneManager.LoadScene("Juego");
        }
        if (CrossPlatformInputManager.GetButton("multi"))
        {

            SceneManager.LoadScene("multijugador");
        }
     
       
        if (CrossPlatformInputManager.GetButton("salir"))
        {
            Debug.Log("Salio");
            Application.Quit();
        }
    }
}
