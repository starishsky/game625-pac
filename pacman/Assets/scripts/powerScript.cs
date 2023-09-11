using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerScript : MonoBehaviour
{
    public bool powerUp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Herb")
        {
            Debug.Log("DONK");
            Destroy(other.gameObject);
            powerUp = true;
            Invoke("powerDown", 1f);
        }
    }

    void powerDown()
    {
        powerUp = false;
    }
}
