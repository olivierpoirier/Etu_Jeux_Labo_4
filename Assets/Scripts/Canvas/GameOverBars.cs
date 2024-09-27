using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverBars : MonoBehaviour
{

    public Slider healthSlider;
    public Slider energySlider;
    public Slider foodSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(healthSlider.value <= 0 || energySlider.value <= 0 || foodSlider.value <= 0) {
            SceneManager.LoadScene("GameOverScene");
            Debug.Log("Game over");
        }

    }


}
