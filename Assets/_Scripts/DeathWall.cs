﻿/* Author: Max Sazhaev, Joshua Korovesi
 * File: Deathwall.cs
 * Creation Date: December 18th 2015
 * Description: This script controls the collision between the instant death area and the player.
 */

using UnityEngine;
using System.Collections;

public class DeathWall : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            // Send to death screen 1
            Application.LoadLevel(3);
        }
    }
}
