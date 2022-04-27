using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript_ : MonoBehaviour
{
    public Button start_button;
    public Button exit_button;
    // Scene current_scene;


    void Start()
    {
        Button s_button = start_button.GetComponent<Button>();
        Button e_button = exit_button.GetComponent<Button>();
        
        s_button.onClick.AddListener(start_button_clicked);
        e_button.onClick.AddListener(exit_button_clicked);
    }

    public void start_button_clicked()
    {
        // Load level menu
        SceneManager.LoadScene(1);
        Debug.Log("You have clicked the Start button"); // start button is cliked which is on main menu
    }

    public void exit_button_clicked()
    {
        Application.Quit();
    }
}
