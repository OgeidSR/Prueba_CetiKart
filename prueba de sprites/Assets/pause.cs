using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class pause : MonoBehaviour
{
    bool active;
    Canvas canvas;
    AudioSource cancion;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        cancion = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButton("pause")) {
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f;
            cancion.mute = !cancion.mute;
        
        
        }
        
    }
}
