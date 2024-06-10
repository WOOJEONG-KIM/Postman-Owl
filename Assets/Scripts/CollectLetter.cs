using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectLetter : MonoBehaviour {

    public GameManager GM;

    private void OnTriggerEnter2D(Collider2D TheThingThatWalkedIntoMe) {
        
        if (TheThingThatWalkedIntoMe.name == "Player") {
            Debug.Log("You Got The Letter");
            GM.CollectLetter();
            Destroy(gameObject);
        }
    }
}
