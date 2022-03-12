using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementoReceta : MonoBehaviour
{
    private bool cocinado;
    // Start is called before the first frame update
    void Awake()
    {
       cocinado = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool revisarSoltar(GameObject mesa){
        bool devuelta = false;
        if(mesa.transform.childCount <= 0){
            devuelta = true;
        } else{
            GameObject objetoenMesa = mesa.transform.GetChild(0).gameObject;
            switch (this.gameObject.tag) {
           case "Huesos":
                if(objetoenMesa.CompareTag("Plato")){
                    if(cocinado == true){
                            combinar(objetoenMesa);
                            devuelta = true;
                    }
                }
                break;
            case "Gusanos":
               devuelta = false;
               break;
       }
        }
       
        return devuelta;
    }

    public void combinar(GameObject objetoAnterior){
       if( this.gameObject.tag == "Huesos" && objetoAnterior.tag == "Plato"){
           //Poner Gameobject combinado de Plato y Huesos.
       }
    }
}
