using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Character : MonoBehaviour
{
    // Start is called before the first frame update

    private CharacterController characterController;

    float inputHorizontal;
    float inputVertical;

    public float Speed = 5f;
    public bool dead;

    public int scoreValue = 0;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));


        characterController.Move(move * Time.deltaTime * Speed);

        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (inputHorizontal > 0)
        {
            gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
        }

        if (inputHorizontal < 0)
        {
            gameObject.transform.localScale = new Vector3(-0.4f, 0.4f, 0.4f);
        }

        
    }
    //all collisions

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Herb")
        {
            Debug.Log("DONK");
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Pellet")
        {
            Destroy(other.gameObject);
            scoreValue = scoreValue + 10;
        }

        if (other.gameObject.tag == "Zombie")
        {
            dead = true;
            Debug.Log("bro you died fr fr");
        }
    }
}
