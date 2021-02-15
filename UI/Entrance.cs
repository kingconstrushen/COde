using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Entrance : MonoBehaviour
{
    public GameObject UiObjectEntrance;
    public AudioSource audioSource;
    public VideoPlayer movieSource;
    // Start is called before the first frame update

    void start ()   
    {
        UiObjectEntrance.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider Entrance) {
        if(Entrance.name == "Player"){
            UiObjectEntrance.SetActive(true);
            audioSource.Play();
            movieSource.Play();

        }
    }

    private void OnTriggerStay(Collider Entrance) {
        if(Entrance.name == "Player"){
            UiObjectEntrance.SetActive(true); 
        }
    }
    
    private void OnTriggerExit(Collider Entrance) {
        if(Entrance.name == "Player"){
            UiObjectEntrance.SetActive(false);
            audioSource.Pause();
            movieSource.Pause();
        }
    }

}
