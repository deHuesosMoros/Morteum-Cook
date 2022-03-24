using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodContainer : MonoBehaviour
{
    public int amountFood;
    public GameObject prefabFood;
    public GameObject decorationContainer;
    public Text text;
    
    void Awake()
    {
        amountFood = 0;
        decorationContainer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = amountFood.ToString();
        if(amountFood > 0 && decorationContainer.activeSelf == false){
            decorationContainer.SetActive(true);
        }else if(amountFood <= 0 && decorationContainer.activeSelf == true){
            decorationContainer.SetActive(false);
        }
    }

    public void increaseNumber(){
        amountFood++;
    }

    public void decreaseNumber(){
        if(amountFood > 0){
            amountFood--;
        } 
    }
}
