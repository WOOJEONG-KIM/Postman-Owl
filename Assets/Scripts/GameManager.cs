using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public int LettersCollected = 0;

    public Text LettersOutput;

    void Update() {
        LettersOutput.text = "Letters: " + LettersCollected;
    }

    void Start() {
        
    }

    public void CollectLetter() {
        LettersCollected ++;
    }

}
