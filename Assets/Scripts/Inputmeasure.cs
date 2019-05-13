using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inputmeasure : MonoBehaviour {

    public int score = 0;
    public Sprite correct; //kleur van correcte timing input
    public AudioClip scoreup; //geluid van correcte timing input
    public AudioClip scoredown; //geluid van incorrecte timing input
    public GameObject scoretext;

    void Start () {
        
    }
	
	void Update () {

    }

    //wanneer de vallende balken in aanraking komen met de input balken
    void OnCollisionEnter2D(Collision2D coll)
    {
        //als op het correcte moment de up pijl ingedrukt wordt wordt de score hoger en wordt displayed, kleur verandert en geluid wordt afgespeeld
        if (Input.GetKey("up"))
        {
            score++;
            Debug.Log(score);
            coll.gameObject.GetComponent<SpriteRenderer>().sprite = correct;
            this.GetComponent<AudioSource>().PlayOneShot(scoreup, .20f);
            displayScore();
        }
        else
        {
            //als NIET op het correcte moment de up pijl ingedrukt wordt wordt de score lager en wordt displayed en geluid wordt afgespeeld
            this.GetComponent<AudioSource>().PlayOneShot(scoredown, .25f);
            score--;
            Debug.Log(score);
            displayScore();
        }
            
    }

    //update het text element
    void displayScore()
    {
        scoretext.GetComponent<Text>().text = "Score: " + score;
    }
}
