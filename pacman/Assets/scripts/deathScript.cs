using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Character charaScript;
    public GameObject deathScreen;
    public GameObject userInt;
    public GameObject disclaimer;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(charaScript.dead == true)
        {
            deathScreen.SetActive(true);
            userInt.SetActive(false);
            disclaimer.SetActive(true);
        }
    }
}
