using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : CatchableObjects
{
     public IngredientType recipeAcumulator;
     public GameObject texture;
    public Material[] materialdishes = new Material[16];

    void Start()
    {
        recipeAcumulator = 0;    
    }

    

    // Update is called once per frame
    void Update()
    {
       
    }

     public void addIngredientToRecipe(IngredientType other){
             recipeAcumulator |= other;
             changeTexture();
        
    }

    public void changeTexture(){
        Debug.Log(recipeAcumulator.ToString());
      switch (recipeAcumulator.ToString()) {
          case "Bone":
              texture.GetComponent<MeshRenderer>().material = materialdishes[2];
              break;
          case "Sesos":
              texture.GetComponent<MeshRenderer>().material = materialdishes[4];
              break;
          case "Worm":
              texture.GetComponent<MeshRenderer>().material = materialdishes[3];
              break;
          case "Blood":
              texture.GetComponent<MeshRenderer>().material = materialdishes[1];
              break;
        case "Blood, Bone":
        case "Bone, Blood":
            texture.GetComponent<MeshRenderer>().material = materialdishes[5];
        break; 
        case "Blood, Sesos":
        case "Sesos, Blood":
            texture.GetComponent<MeshRenderer>().material = materialdishes[6];
        break; 
        case "Blood, Worm":
        case "Worm, Blood":
            texture.GetComponent<MeshRenderer>().material = materialdishes[7];
        break;
        case "Sesos, Bone":
        case "Bone, Sesos":
            texture.GetComponent<MeshRenderer>().material = materialdishes[8];
        break;
        case "Sesos, Worm":
        case "Worm, Sesos":
            texture.GetComponent<MeshRenderer>().material = materialdishes[9];
        break;
        case "Bone, Worm":
        case "Worm,Bone":
            texture.GetComponent<MeshRenderer>().material = materialdishes[10];
        break;
        case "Blood, Sesos, Worm":
        case "Blood, Worm, Sesos":
        case "Sesos, Blood, Worm":
        case "Sesos, Worm, Blood":
        case "Worm, Sesos, Blood":
        case "Worm, Blood, Sesos":
            texture.GetComponent<MeshRenderer>().material = materialdishes[11];
        break;
        case "Blood, Worm, Bone":
        case "Blood, Bone, Worm":
        case "Worm, Blood, Bone":
        case "Worm, Bone, Blood":
        case "Bone, Worm, Blood":
        case "Bone, Blood, Worm":
            texture.GetComponent<MeshRenderer>().material = materialdishes[12];
        break;
        case "Bone, Blood, Sesos":
        case "Bone, Sesos, Blood":
        case "Blood, Sesos, Bone":
        case "Blood, Bone, Sesos":
        case "Sesos, Bone, Blood":
        case "Sesos, Blood, Bone":
            texture.GetComponent<MeshRenderer>().material = materialdishes[13];
        break;
        case "Sesos, Worm, Bone":
        case "Sesos, Bone, Worm":
        case "Worm, Sesos, Bone":
        case "Worm, Bone, Sesos":
        case "Bone, Worm, Sesos":
        case "Bone, Sesos, Worm":
            texture.GetComponent<MeshRenderer>().material = materialdishes[14];
        break;
       
          default :
              
              break;
      }
    }
}
