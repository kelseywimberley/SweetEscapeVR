using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerControls : MonoBehaviour
{
    public bool hershel;

    public GameObject hershelPos;
    public GameObject gretaPos;

    public float inRoomVolume = 0.75f;
    public float outRoomVolume = 0.25f;

    public InputActionReference switchCharacterButton;

    void Start()
    {
        hershel = true;
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
        switchCharacterButton.action.performed += SwitchCharacter;
    }
    private void OnDisable()
    {
        switchCharacterButton.action.performed -= SwitchCharacter;
    }

    private void SwitchCharacter(InputAction.CallbackContext obj)
    {
        if (hershel)
        {
            hershelPos.transform.position = transform.position;
            hershelPos.transform.rotation = transform.rotation;
            transform.position = gretaPos.transform.position;
            hershel = false;
        }
        else
        {
            gretaPos.transform.position = transform.position;
            gretaPos.transform.rotation = transform.rotation;
            transform.position = hershelPos.transform.position;
            hershel = true;
        }
    }
}
