using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class peirama2 : MonoBehaviour
{
    
    public GameObject model;
    public GameObject model2;
    public GameObject model3;
    public GameObject model4;
    public GameObject model5;
    public GameObject model6;
    public GameObject model7;
    public GameObject model8;
    public GameObject model9;
    public GameObject model10;
    public GameObject model11;
    public GameObject model12;




    public void Sindetiras()
    {



        model.SetActive(true);
        model2.SetActive(true);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(false);
        model6.SetActive(false);
        model7.SetActive(false);
        model8.SetActive(false);
        model9.SetActive(false);
        model10.SetActive(false);
        model11.SetActive(false);
        model12.SetActive(false);

    }


    public void Potiri()
    {

        model.SetActive(true);
        model2.SetActive(false);
        model3.SetActive(true);
        model4.SetActive(false);
        model5.SetActive(false);
        model6.SetActive(false);
        model7.SetActive(false);
        model8.SetActive(false);
        model9.SetActive(false);
        model10.SetActive(false);
        model11.SetActive(false);
        model12.SetActive(false);



    }


    public void Velona()
    {

        model.SetActive(true);
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(true);
        model5.SetActive(false);
        model6.SetActive(false);
        model7.SetActive(false);
        model8.SetActive(false);
        model9.SetActive(false);
        model10.SetActive(false);
        model11.SetActive(false);
        model12.SetActive(false);



    }


    public void Daxtilidi()
    {
        model.SetActive(true);
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(true);
        model6.SetActive(false);
        model7.SetActive(false);
        model8.SetActive(false);
        model9.SetActive(false);
        model10.SetActive(false);
        model11.SetActive(false);
        model12.SetActive(false);

    }


    public void Stilo()
    {
        model.SetActive(true);
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(false);
        model6.SetActive(true);
        model7.SetActive(false);
        model8.SetActive(false);
        model9.SetActive(false);
        model10.SetActive(false);
        model11.SetActive(false);
        model12.SetActive(false);

    }

    public void EPOMENO()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }


 
    }
