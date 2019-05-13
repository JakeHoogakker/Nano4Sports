using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioInfo : MonoBehaviour {

    [System.Serializable]

    //Geeft info weer van een lied om het tempo aan te passen
    public class songs
    {
        public AudioClip number;
        public float tempo;
        public int buttonsnecessary;
        public float volume;
    }


    public List<songs> allsongs = new List<songs>();
    public songs currentsong;
    public int songtoplay;


    void Start () {
        /*songtoplay = 0;
        PlaySong();*/
    }
	
	void Update () {

        //Druk zsm een van deze keys om het spel goed te laten werken.Je kan niet switchen van lied later omdat de spawn nog niet perfect werkt.
        if (Input.GetKeyDown("down"))
            {
            songtoplay = 0;
            PlaySong();
        }
        else if (Input.GetKeyDown("left"))
        {
            songtoplay = 1;
            PlaySong();
        }

    }

    //selecteert een lied en deze
    void PlaySong()
    {
        currentsong = allsongs[songtoplay];
        this.GetComponent<AudioSource>().clip = currentsong.number;
        this.GetComponent<AudioSource>().Play();
        this.GetComponent<AudioSource>().volume = currentsong.volume;
        
    }
}
