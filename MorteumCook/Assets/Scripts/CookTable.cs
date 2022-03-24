using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookTable : Table
{
    public float timeCook = 0;
    //public RawImage progres;
    public Image progressBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isEmpty() == false){
            if(tablePoint.transform.GetChild(0).GetComponent<Ingredient>().isCooked == false){
                timeCook ++;
                Debug.Log("Time to cook "+ timeCook);
                IncreaseTimeBar();
                if(timeCook >= 80){
                Cooked(tablePoint.transform.GetChild(0).GetComponent<Ingredient>()); 
            } 
            }
        }else{
            timeCook = 0;
        }
    }


    public void IncreaseTimeBar()
    {
        float barProgress = Remap(timeCook, 0, 80, 0, 1);
        progressBar.fillAmount = barProgress;
    }

    public void Reset()
    {
        progressBar.fillAmount = 0;
    }



}
