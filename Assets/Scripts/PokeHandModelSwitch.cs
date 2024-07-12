using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokeHandModelSwitch : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Poke")
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Poke")
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
