using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_iteam : MonoBehaviour
{
    public GameObject rend;
    public GameObject text1;
    public AudioSource swsto;


    private void OnTriggerEnter(Collider player)
    {
        
        if (player.gameObject.tag == "Player")
            {
            Destroy(rend);
            Destroy(text1);
            swsto.Play();


        }
    }
}
