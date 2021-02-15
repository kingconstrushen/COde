using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yard : MonoBehaviour
{
    public GameObject UiObjectYard;
    // Start is called before the first frame update

    void start ()   
    {
        UiObjectYard.SetActive(false);
    }

    private void OnTriggerEnter(Collider yard) {
        if(yard.name == "Player"){
            UiObjectYard.SetActive(true);

        }
    }

    private void OnTriggerStay(Collider yard) {
        if(yard.name == "Player"){
            UiObjectYard.SetActive(true); 
        }
    }
    
    private void OnTriggerExit(Collider yard) {
        if(yard.name == "Player"){
            UiObjectYard.SetActive(false);
        }
    }

}
