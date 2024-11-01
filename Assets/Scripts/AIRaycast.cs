using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiRaycast : MonoBehaviour
{

    // Variable sérialisée exposée dans l'inspecteur pour ajuster la vitesse du robot dans Unity
    [SerializeField] float speed = 1f;
 
    // Déclaration d'un rayon qui sera utilisé pour détecter les obstacles devant le robot
    Ray rayon;
 
    // Déclaration d'une variable pour stocker les informations de collision lorsque le rayon touche un objet
    RaycastHit hit;
 
    // Variables sérialisées pour assigner les capteurs gauche et droit du robot dans l'éditeur Unity
    [SerializeField] Transform leftSensor, rightSensor;


 
    // Déclaration d'une variable pour stocker les informations de collision
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rayon = new Ray(leftSensor.position, transform.TransformDirection(Vector3.forward));
        if(Physics.Raycast(rayon, out hit, Mathf.Infinity)) {
            if(hit.distance <3) {
                float angle = Random.Range(100f, 300f);

                transform.Rotate(Vector3.up * angle * (Time.deltaTime / 4));
            }
        }
        Debug.DrawRay(leftSensor.position, transform.TransformDirection(Vector3.forward)* 10f, Color.yellow);


        rayon = new Ray(rightSensor.position, transform.TransformDirection(Vector3.forward));
        if(Physics.Raycast(rayon, out hit, Mathf.Infinity)) {
            if(hit.distance <3) {
                float angle = Random.Range(100f, 300f);

                transform.Rotate(Vector3.up * angle * (Time.deltaTime / 4));
            }
        }
        Debug.DrawRay(rightSensor.position, transform.TransformDirection(Vector3.forward)* 10f, Color.yellow);
        transform.Translate(Vector3.forward * speed * (Time.deltaTime/4));
    }
}
