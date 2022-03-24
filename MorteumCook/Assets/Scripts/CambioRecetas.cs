using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CambioRecetas : MonoBehaviour
{

    public Image imagenUI;


    // Start is called before the first frame update
    void Start()
    {
        imagenUI = GameObject.Find("Dish Icon").GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))

        {
            imagenUI.sprite = Resources.Load<Sprite>("Sprites/Plato");
        }

        if (Input.GetKeyDown("o"))

        {
            imagenUI.sprite = Resources.Load<Sprite>("Sprites/Gusanos-Sesos");
        }

    }

    
   

}
