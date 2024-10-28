using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableitemcontroler : MonoBehaviour
{

    public PlayerController playerController;

    void Start()
    {
        
    }

    void Update()
    {



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player")
        {

            playerController.zebranePunkty++;

            Debug.Log(playerController.zebranePunkty);

            Destroy(this.gameObject);
        }

    }




    }








