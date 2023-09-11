using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Character charaScript;

    public Text scoreText;


    void Start()
    {
        charaScript = FindObjectOfType<Character>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "SCORE: " + charaScript.scoreValue;
    }
}
