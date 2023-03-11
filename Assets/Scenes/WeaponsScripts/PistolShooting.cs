using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolShooting : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            animator.Play("Shooting");
        }    

        if (Input.GetKey(KeyCode.R))
        {
            animator.Play("Reload");
        }
    }
}
