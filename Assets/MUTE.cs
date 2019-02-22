using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MUTE : MonoBehaviour
{
    public bool mute;
    private Animator anim;
    AudioSource Root;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        mute = false;
        Root = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       
        anim.SetBool("mute", mute);
        if (CrossPlatformInputManager.GetButton("mute"))
        {
            Root.mute = !Root.mute;
            mute = !mute;
        }

    }
  
}

