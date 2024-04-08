using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_iteam_end : MonoBehaviour
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
            swsto.Play();

        }
    }
}

