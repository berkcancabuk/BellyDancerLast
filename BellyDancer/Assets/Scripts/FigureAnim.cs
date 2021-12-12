using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureAnim : MonoBehaviour
{
    public Animator anim;
    public MainConts main_conts;
    
    // Update is called once per frame
    void Update()
    {
        if (main_conts.AnimController.GetBool("FirstAllTriggers") == true)
        {
            anim.SetBool("FirstAllTriggers2", true);
        }
        if (main_conts.AnimController.GetBool("SecondAllTriggers") == true)
        {
            anim.SetBool("SecondAllTriggers2", true);
           
        }
        if (main_conts.AnimController.GetBool("Fall") == true)
        {
            anim.SetBool("Fall2", true);
        }
    }
}
