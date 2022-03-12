using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodContainer : MonoBehaviour
{
    public int amountFood;
    public GameObject prefabFood;
    
    void Awake()
    {
        amountFood = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
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
