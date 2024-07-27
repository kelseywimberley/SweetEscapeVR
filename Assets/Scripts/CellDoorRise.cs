using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellDoorRise : MonoBehaviour
{
    private PlayerControls sPlayerControls;
    private bool inHershelRoom;
    public float maxHeight;

    private bool rise;
    private float speed;
    private AudioSource audioSource;

    void Start()
    {
        sPlayerControls = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControls>();

        inHershelRoom = false;
        if (transform.position.z < 7.5f)
        {
            inHershelRoom = true;
        }

        rise = false;
        speed = 5.0f;
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (rise)
        {
            if ((sPlayerControls.hershel && inHershelRoom) ||
                (!sPlayerControls.hershel && !inHershelRoom))
            {
                audioSource.volume = sPlayerControls.inRoomVolume;
            }
            else
            {
                audioSource.volume = sPlayerControls.outRoomVolume;
            }

            transform.position += new Vector3(0, speed * Time.deltaTime, 0);

            if (transform.position.y > maxHeight)
            {
                rise = false;
                audioSource.Stop();
            }
        }
    }

    public void BeginRising()
    {
        Debug.Log("Activated");
        rise = true;
        audioSource.Play();
    }
}
