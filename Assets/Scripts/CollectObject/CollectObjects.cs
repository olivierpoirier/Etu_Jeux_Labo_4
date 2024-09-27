using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CollectObjects : MonoBehaviour
{

    public Slider healthBar;
    public Text textHealthBar;
    public Slider energyBar;
    public Text textEnergyBar;
    public Slider foodBar;
    public Text textFoodBar;

    public float gainHealthValue = 0.02f;

    public float gainEnergyValue = 0.02f;

    public float gainFoodValue = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        print("collision");

   
        if(collision.collider.CompareTag("Food")) {
            healthBar.value += gainHealthValue;
            textHealthBar.text = healthBar.value.ToString() + "%";

            foodBar.value += gainFoodValue;
            textFoodBar.text = foodBar.value.ToString() + "%";

            Destroy(collision.collider.gameObject);
        }


        if(collision.collider.CompareTag("Energy")) {
            energyBar.value += gainEnergyValue;
            textEnergyBar.text = energyBar.value.ToString() + "%";

            Destroy(collision.collider.gameObject);
        }


    }
}
