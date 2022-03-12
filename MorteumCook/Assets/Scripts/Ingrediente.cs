using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Flags]
 public enum IngredientType
 {
     Worm = (1 << 0),
     Blood = (1 << 1),
     Bone = (1 << 2),
     Meat = (1 << 3),
 }

public class Ingrediente : MonoBehaviour
{
    public IngredientType type;

     public IngredientType recipe;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
