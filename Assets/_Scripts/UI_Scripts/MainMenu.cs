/*
 Filename: MainMenu.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 20/11/2020
 Description: This file load the playscene and have the function for the buttons in the Mainmenu.
 Revision History:
 20/11/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //mainmenu function
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
