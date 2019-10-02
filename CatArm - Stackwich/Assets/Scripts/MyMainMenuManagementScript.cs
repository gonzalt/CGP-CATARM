using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyMainMenuManagementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void LoadEndlessLevel()
	{
		SceneManager.LoadScene("EndlessLevel");
	}
	
	public void LoadLevelSelect()
	{
		SceneManager.LoadScene("LevelSelect");
	}
	
	public void LoadCredits()
	{
		SceneManager.LoadScene("Credits");
	}
	
	public void LoadMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
	
	
	
	
	
	
}
