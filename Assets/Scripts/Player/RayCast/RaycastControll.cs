using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastControll : MonoBehaviour
{

    public float seenRange = 4.0f;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        //Si le rayon touche un objet dans une sa range, fait quelque chose
        if (Physics.Raycast(transform.position, transform.forward, out hit, seenRange))
        {
            string message = "You are seeing " + hit.transform.name + ". ";

            //Si l'objet a le tag "Destroyable", appuyez sur K pour le détruire
            if(hit.transform.tag == "Destroyable") {
                message += "PRESS K TO DESTROY IT";
                if(Input.GetKeyDown(KeyCode.K)) {
                    Destroy(hit.transform.gameObject);
                }
                
            }
            print(message);
   
        }
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)* seenRange, Color.magenta);
    }
    
}