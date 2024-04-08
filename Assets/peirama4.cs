using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class peirama4 : MonoBehaviour
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
    public GameObject model13;




    public void Phase1()
    {



        model.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(false);
        model6.SetActive(false);
        model7.SetActive(true);
        model8.SetActive(true);
        model9.SetActive(false);
        model10.SetActive(false);
        model11.SetActive(false);
        model12.SetActive(false);
        model13.SetActive(false);

    }


    public void Phase2()
    {

        model.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(false);
        model6.SetActive(false);
        model7.SetActive(false);
        model8.SetActive(false);
        model9.SetActive(true);
        model10.SetActive(true);
        model11.SetActive(false);
        model12.SetActive(false);
        model13.SetActive(false);



    }


    public void Phase3()
    {

        model.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(false);
        model6.SetActive(false);
        model7.SetActive(false);
        model8.SetActive(false);
        model9.SetActive(true);
        model10.SetActive(true);
        model11.SetActive(true);
        model12.SetActive(true);
        model13.SetActive(false);



    }


    public void Phase4()
    {
        model.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(false);
        model4.SetActive(false);
        model5.SetActive(false);
        model6.SetActive(false);
        model7.SetActive(false);
        model8.SetActive(false);
        model9.SetActive(true);
        model10.SetActive(true);
        model11.SetActive(false);
        model12.SetActive(true);
        model13.SetActive(true);

    }

    public void EPOMENO()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

}
