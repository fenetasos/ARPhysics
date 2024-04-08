using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sound_evend : MonoBehaviour
{
    public AudioSource lathos;


    private void OnTriggerEnter(Collider player)
    {

        if (player.gameObject.tag == "Player")
        {
            
            lathos.Play();


        }
    }

}
