using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScrollMM : MonoBehaviour
{
    public GameObject creditsButton;
    public bool scroll;
    float startHeight;
    float maxHeight;

    void Start()
    {
        scroll = false;
        startHeight = -10.0f;
        maxHeight = 40.0f;
        transform.position = new Vector3(0, startHeight, 0);
    }

    void Update()
    {
        if (scroll)
        {
            transform.position += new Vector3(0, 0.1f, 0);

            if (transform.position.y > maxHeight)
            {
                transform.position = new Vector3(0, startHeight, 0);
                scroll = false;
                creditsButton.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }

    public void StartScrolling()
    {
        scroll = true;
    }
}
