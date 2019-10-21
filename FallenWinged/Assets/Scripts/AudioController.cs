using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{  
    public GameObject
        musicMain,
        musicMenu,
        musicGameplay;   
    // Start is called before the first frame update
    void Start()
    {
        PlayMusic(musicMain);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic(GameObject play)
    {
        musicMain.GetComponent<AudioSource>().Stop();
        musicMenu.GetComponent<AudioSource>().Stop();
        musicGameplay.GetComponent<AudioSource>().Stop();
        play.GetComponent<AudioSource>().Play();       
    }
}
