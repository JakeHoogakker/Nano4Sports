
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnObject : MonoBehaviour
{


    public float timer = 0;
    public GameObject spawner;
    public Sprite reset; //kleur van de balken zonder input
    GameObject audioInfo; //object dat de muziek speelt


    void Start()
    {
        //object in scene met de audio
        audioInfo = GameObject.Find("Canvas");
    }

    void Update()
    {
        timer++;

        //Als het object ver genoeg is uit het beeld wordt die respawned.
        if (timer == audioInfo.GetComponent<audioInfo>().currentsong.tempo * (10 * audioInfo.GetComponent<audioInfo>().currentsong.buttonsnecessary))
        {
            GetComponent<SpriteRenderer>().sprite = reset;
            transform.position = new Vector2(this.transform.position.x, spawner.transform.position.y);
            timer = 0;
        }
    }

}