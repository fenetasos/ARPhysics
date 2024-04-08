using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class thesh : MonoBehaviour
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
    
    



    public void Phase1()
    {



        model.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(true);
        model4.SetActive(true);
        model5.SetActive(true);
        model6.SetActive(true);
        model7.SetActive(true);
        model8.SetActive(false);
        model9.SetActive(false);
        model10.SetActive(false);
       
      
    }


    public void Phase2()
    {

        model.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(true);
        model4.SetActive(true);
        model5.SetActive(false);
        model6.SetActive(true);
        model7.SetActive(true);
        model8.SetActive(true);
        model9.SetActive(false);
        model10.SetActive(false);
       


       
    }


    public void Phase3()
    {

        model.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(true);
        model4.SetActive(true);
        model5.SetActive(false);
        model6.SetActive(false);
        model7.SetActive(true);
        model8.SetActive(true);
        model9.SetActive(true);
        model10.SetActive(false);




    }


    public void Phase4()
    {
        model.SetActive(false);
        model2.SetActive(false);
        model3.SetActive(true);
        model4.SetActive(true);
        model5.SetActive(false);
        model6.SetActive(false);
        model7.SetActive(false);
        model8.SetActive(true);
        model9.SetActive(true);
        model10.SetActive(true);


    }


    public void EPOMENO()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }


    void Update()
    {
        
    }

  




}
