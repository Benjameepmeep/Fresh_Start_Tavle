using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUserInterfaceManager : MonoBehaviour
{
    public PlayerHealthManager _playerHealth;

    public Image[] hearts;

    private void Update()
    {
        for (int i = 0; i < hearts.Length-1; i++)
        {
            hearts[i].color = i < _playerHealth.lives
                    ? new Color(0.9f, 0.2f, 0.2f, 1f)
                    : new Color(0.4f, 0.2f, 0.2f, 1f);
        }
    }
}