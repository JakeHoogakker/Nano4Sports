using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject button; //de vallende balken
    int leftright = -50; //positie van de balken
    public float timer = 0.0f;
    int beforetimer = 0; //geeft aan hoeveel keer er een instance gemaakt moet worden
    public List<GameObject> allinstances;
    public float musictempo;
    public GameObject audioInfo; //object dat de muziek speelt

    void Start () {

    }
	
	void Update () {
        timer++;

        //spawned een instance van de vallende balken zodra de timer gelijk loopt met het tempo en er minder balken zijn dan nodig is
        if (timer == audioInfo.GetComponent<audioInfo>().currentsong.tempo && beforetimer < 10 * audioInfo.GetComponent<audioInfo>().currentsong.buttonsnecessary)
        { 
            allinstances.Add(Instantiate(button, new Vector2(this.transform.position.x + leftright, this.transform.position.y), Quaternion.identity));

            //links of rechts spawn
            if (leftright == -50)
            {
                leftright = 50;
            }
            else
            {
                leftright = -50;
            }
            timer = 0;
            beforetimer++;
        }
    }
}
