using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{   
    [HideInInspector]public GameObject tablePoint;
    public IngredientType ingredientAllowed;

    
    
    void Awake()
    {
        tablePoint = this.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isEmpty() {
        if(tablePoint.transform.childCount > 0){
            return false;
        }else{
            return true;
        }
    }

    virtual public bool canUseTable(GameObject other){
        bool validator = false;
       if(isEmpty()){
           Ingredient ingredient = other.GetComponent<Ingredient>();
           if(ingredient){
               IngredientType ingredientProvided = ingredient.type;
                if(ingredientAllowed.HasFlag(ingredientProvided)){
                    validator = true;
                }
           }
            
       }
       return validator;
    }

    public void Cooked(Ingredient ingredient){
        ingredient.isCooked = true;
    }


    public float Remap(float from, float fromMin, float fromMax, float toMin, float toMax)
    {
        var fromAbs = from - fromMin;
        var fromMaxAbs = fromMax - fromMin;

        var normal = fromAbs / fromMaxAbs;

        var toMaxAbs = toMax - toMin;
        var toAbs = toMaxAbs * normal;

        var to = toAbs + toMin;

        return to;
    }
}
