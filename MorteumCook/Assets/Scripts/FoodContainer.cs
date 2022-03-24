using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodContainer : MonoBehaviour
{
    public int amountFood;
    public GameObject prefabFood;
    public GameObject decorationContainer;
    
    void Awake()
    {
        amountFood = 0;
        decorationContainer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
