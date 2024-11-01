using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject : MonoBehaviour, iGazeReceiver 
{

    //https://www.immersivelimit.com/detect-when-looking-at-object
    private bool isGazingUpon;

    public float floatingSpeed;

    public AudioSource audioSourceOfEntity;

    public AudioClip audioClipGun;

    public AudioClip audioCliSomethingDied;


    public void GazingUpon()
    {
        isGazingUpon = true;

    }

    public void NotGazingUpon()
    {
        isGazingUpon = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //Si la fonction "GazingUpon" a été activée sur l'objet
        //(Grâce à la classe GazeManager), on peut intéragir avec l'objet.


        //La fonction "GazingUpon" arrive quand la caméra du joueur fait face à un objet
        if (isGazingUpon)
        {
            if(Input.GetKeyDown(KeyCode.E)) {
            
            }
            if(Input.GetKeyDown(KeyCode.K)) {
                Destroy(gameObject);
  
                
            }
            if(Input.GetKeyDown(KeyCode.L)) {
                transform.Translate(Vector3.up * floatingSpeed * Time.deltaTime);
            }
            transform.Rotate(0, 3, 0);
        }
    }
}
