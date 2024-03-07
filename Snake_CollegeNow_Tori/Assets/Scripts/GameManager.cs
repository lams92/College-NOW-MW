using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    //IN CLASS COLLEGE NOW

    //GLOBAL VARIABLES
    public TextMeshProUGUI foodScoreText; //text object for food score text
    public int foodScore = 0; //declare and set initial Food Score

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foodScoreText.text = "Score: " + foodScore; //update foodScoreText UI
    }

    public void FoodEaten()
    {
        foodScore++; //add 1 to food score
    }
}
