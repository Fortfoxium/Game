using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RUNRUNJOHNY : MonoBehaviour
{
   PUBLIC Transform igrok ;
   public int speed ;

   
    void Update()
    {
        if (input.Getkey (KeyCode.LEFTSHIFT) )
        igrok.Transform.translate(vector3.forward*speed*Time.deltaTime)
    }
}
