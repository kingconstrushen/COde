using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public bool menuIsOpen;
    public GameObject UiMenu;

    void start(){
        UiMenu.SetActive(false);
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape) && menuIsOpen == false){
            pause();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && menuIsOpen == true){
            resume();
        }
    }

    void resume () 
    {
        UiMenu.SetActive(false);
        menuIsOpen = false;
       Time.timeScale = 1f;
       Cursor.lockState = CursorLockMode.Locked;
    }

    void pause () 
    {
        UiMenu.SetActive(true);
        menuIsOpen = true;
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
    }
}
