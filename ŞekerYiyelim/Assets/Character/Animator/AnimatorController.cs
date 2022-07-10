using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("ileri", true);
        }
        if (!Input.GetKey(KeyCode.W) )
        {
            anim.SetBool("ileri", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            
            anim.SetBool("geri", true);
        }
        if (!Input.GetKey(KeyCode.S))
        {
            anim.SetBool("geri", false);
        }

        if (Input.GetAxis("Horizontal")!=0)
        {
            anim.SetBool("yan", true);
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            anim.SetBool("yan", false);
        }


    }
}
