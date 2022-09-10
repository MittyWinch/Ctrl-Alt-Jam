using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dash : MonoBehaviour

{
    public GameObject Power1;
    Player_Controller moveScript;
    public float dashSpeed;
    public float dashTime;

    void Start()
    {
        moveScript = GetComponent<Player_Controller>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        PowerUpOne();
    }

    public void PowerUpOne()
    {
        Power1.SetActive(true);
    }
}
