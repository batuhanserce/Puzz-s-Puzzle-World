using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMenuScript_ : MonoBehaviour
{
    // LEVEL BUTTON NUMBERS BELOW
    public Button first, second, third, fourth, fifth;
    public Button sixth, seventh, eighth, nineth, tenth;

    // second_level_button, third_level_button
    void Start()
    {
        Button level1_button = first.GetComponent<Button>();
        Button level2_button = second.GetComponent<Button>();
        Button level3_button = third.GetComponent<Button>();
        Button level4_button = fourth.GetComponent<Button>();
        Button level5_button = fifth.GetComponent<Button>();
        Button level6_button = sixth.GetComponent<Button>();
        Button level7_button = seventh.GetComponent<Button>();
        Button level8_button = eighth.GetComponent<Button>();
        Button level9_button = nineth.GetComponent<Button>();
        Button level10_button = tenth.GetComponent<Button>();

        level1_button.onClick.AddListener(enter_level_one);
        level2_button.onClick.AddListener(enter_level_two);
        level3_button.onClick.AddListener(enter_level_three);
        level4_button.onClick.AddListener(enter_level_four);
        level5_button.onClick.AddListener(enter_level_five);
        level6_button.onClick.AddListener(enter_level_six);
        level7_button.onClick.AddListener(enter_level_seven);
        level8_button.onClick.AddListener(enter_level_eight);
        level9_button.onClick.AddListener(enter_level_nine);
        level10_button.onClick.AddListener(enter_level_ten);
    }
    
    public void enter_level_one()
    {
        SceneManager.LoadScene(2);
        Debug.Log("You have clicked to Level 1 Button");  
    }

    public void enter_level_two()
    {
        SceneManager.LoadScene(3);
        Debug.Log("You have clicked to Level 2 Button");
    }

    public void enter_level_three()
    { 
        SceneManager.LoadScene(4);
        Debug.Log("You have clicked to Level 3 Button");
    }

    public void enter_level_four()
    {
        SceneManager.LoadScene(5);
        Debug.Log("You have clicked to Level 4 Button");
    }

    public void enter_level_five()
    {
        SceneManager.LoadScene(6);
        Debug.Log("You have clicked to Level 5 Button");
    }

    public void enter_level_six()
    {
        SceneManager.LoadScene(7);
        Debug.Log("You have clicked to Level 6 Button");
    }

    public void enter_level_seven()
    {
        SceneManager.LoadScene(8);
        Debug.Log("You have clicked to Level 7 Button");
    }

    public void enter_level_eight()
    {
        SceneManager.LoadScene(9);
        Debug.Log("You have clicked to Level 8 Button");
    }

    public void enter_level_nine()
    {
        SceneManager.LoadScene(10);
        Debug.Log("You have clicked to Level 9 Button");
    }

    public void enter_level_ten()
    {
        SceneManager.LoadScene(11);
        Debug.Log("You have clicked to Level 10 Button");
    }

}
