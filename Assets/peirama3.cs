using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class peirama3 : MonoBehaviour
{
    public GameObject model;
    public GameObject model2;
    public GameObject model3;
    public GameObject model4;
    public GameObject model5;

    public void EKTELESI()
    {



        model.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(true);

    }

    public void EPOMENO()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

}
