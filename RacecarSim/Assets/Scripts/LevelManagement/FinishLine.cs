﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField]
    private BestTimes.Level level;

    private void Start()
    {
        foreach (GameObject player in GameObject.FindGameObjectsWithTag("Player"))
        {
            player.GetComponent<Racecar>().SetIsWinable();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Racecar player = other.attachedRigidbody.GetComponent<Racecar>();
        if (player != null)
        {
            player.HandleFinish(level);
        }
    }
}
