/*
 Filename: MainMenu.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 20/11/2020
 Description: This file have everything for the Game Over Scene.
 Revision History:
 20/11/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
    public void GameOverButton()
    {
        SceneManager.LoadScene(2);
    }
}
