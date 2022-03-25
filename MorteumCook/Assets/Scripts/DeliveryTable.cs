using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeliveryTable : Table
{
    public GameManager manager;
    public GameObject incorrect;
    public GameObject correct;
    public float timeForAdvice = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty() == false){
            Recipe recipeProvided = tablePoint.transform.GetChild(0).GetComponent<Recipe>();
            if(manager.choosedRecipe  == recipeProvided.recipeAcumulator){
                timeForAdvice += Time.time;
                manager.winPoints();
                manager.newRecipe();
                correct.SetActive(true);
                 
            }else{
                 timeForAdvice += Time.time;
                incorrect.SetActive(true);
                
               
            }
            Destroy(tablePoint.transform.GetChild(0).gameObject);
        }
        
                    
        
    }

    override public bool canUseTable(GameObject other){
        bool validator = false;
        if(isEmpty()){
            Recipe isRecipe = other.transform.GetComponent<Recipe>();
            if(isRecipe){
                validator =  true;
            }
        }
        return validator;
    }

    
}
