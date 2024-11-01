using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeManager : MonoBehaviour
{
    //https://www.immersivelimit.com/detect-when-looking-at-object


    //La caméra du joueur
    public Camera viewCamera;

    //L'objet qui est en face du joueur
    private GameObject lastGazedUpon;

    // Update is called once per frame
    void Update()
    {
        CheckGaze();
    }

    private void CheckGaze() {

        //S'il n'y a pas d'objets devant le joueur, Active la fonction nommée
        //"NotGazingUpon" dans les objets ayant la fonction
        if (lastGazedUpon) {
            lastGazedUpon.SendMessage("NotGazingUpon", SendMessageOptions.DontRequireReceiver);
        }


        //Crée un rayon devant la caméra du joueur pour détecter des objets
        Ray gazeRay = new Ray(viewCamera.transform.position, viewCamera.transform.rotation * Vector3.forward);
        RaycastHit hit;

        //Si le rayon touche un objet dans une range (ici la range est infinie)
        if (Physics.Raycast(gazeRay, out hit, Mathf.Infinity))
        {
            //Active la fonction "GazingUpon" dans l'objet qui est vu par le rayon.
            hit.transform.SendMessage("GazingUpon", SendMessageOptions.DontRequireReceiver);
            lastGazedUpon = hit.transform.gameObject;
        }
        Debug.DrawRay(viewCamera.transform.position, transform.TransformDirection(Vector3.forward)* 10f, Color.magenta);
    }
    
}