﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_deform : MonoBehaviour
{
    public GameObject Player;


    // Update is called once per frame
    void Update()
    {
        float distance;
        distance = Vector3.Distance(Player.transform.position, transform.position);
        if (distance > 5.0f && distance < 15.0f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, ((distance + 1.3f) / 3), transform.localPosition.z);
            transform.localScale = new Vector3((15 - distance) * 0.025f, (15 - distance) * 0.025f, (15 - distance) * 0.025f);

        }
        else if (distance > 15.0f)
        {
            transform.localScale = new Vector3(0, 0, 0);
        }      

    }
}
