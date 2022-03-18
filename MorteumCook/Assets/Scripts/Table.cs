using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{   
    [HideInInspector]public GameObject tablePoint;
    [HideInInspector] public IngredientType tableIngredientType;
    public IngredientType receta;

    public IngredientType recetaUI;

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
       return true;
    }


    virtual public  bool ValidateIngredient(IngredientType ingredient) 
    {
        bool validation = false;
        if (tableIngredientType.HasFlag(ingredient))
        {
            Debug.Log("Ingrediente correcto");
        }
        else
        {
            Debug.Log("No coincide ingrediente");
        }

        return validation;
    }

    virtual public bool ValidateRecipe() 
    {
        if (recetaUI == receta)
        {
            Debug.Log("Receta Correcta");
        }
        else
        {
            Debug.Log("Receta Incorrecta");
        }
        
        return recetaUI.HasFlag(receta);        
    }


    virtual public void AddIngredient(IngredientType ingredient) 
    {
        receta |= ingredient;
        //IngredientType temporal = receta |= ingredient;
    }

    virtual public void RemoveIngredient(IngredientType ingredient) 
    {
        receta &= ~ingredient;
    }

}
