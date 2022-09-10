using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect_System : MonoBehaviour

{
    public GameObject Power1;
    public GameObject Power2;
    public GameObject Power3;
    public GameObject Power4;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        PowerUpOne();
    }

    public void PowerUpOne()
    {
        Power1.SetActive(true);
    }
    public void PowerUpTwo()
    {
        Power2.SetActive(true);
    }
    public void PowerUpThree()
    {
        Power3.SetActive(true);
    }
    public void PowerUpFour()
    {
        Power4.SetActive(true);
    }
}
