using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiHandler : MonoBehaviour
{
    [Header("Button")]
    public GameObject MenuButton;
    public GameObject BackButton;

    [Header("Panel")]
    public GameObject SocietyView;
    public GameObject FloorPlan;
    


    void Start()
    {
        SocietyView.SetActive(false);
        FloorPlan.SetActive(false);
        BackButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Slide()
    {
        MenuButton.SetActive(false);
        SocietyView.SetActive(true);
        BackButton.SetActive(true);
    }
    public void Back()
    {
        SocietyView.SetActive(true);
        FloorPlan.SetActive(false);
        MenuButton.SetActive(true);
    }
    public void FloorPlanPanel()
    {
        SocietyView.SetActive(false);
        FloorPlan.SetActive(true);
        MenuButton.SetActive(false);
        BackButton.SetActive(true);

    }
}
