using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string campaignScene;
    private string versusScene;
    private string trainingScene;

    public CharacterSelect character1;
    public CharacterSelect character2;
    public StageSelect stage;

    private bool gameVersus;
    private bool gameCampaign;
    private bool gameTraining;

    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject charMenu;
    public GameObject stageMenu;

    public GameObject backgroundManager;

    public GameObject SelectBackground;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Campaign()
    {
        gameCampaign = true;
        charMenu.SetActive(true);
        mainMenu.SetActive(false);
        SelectBackground.SetActive(false);
    }

    public void Versus()
    {
        //SceneManager.LoadScene(versusScene);
        gameVersus = true;
        charMenu.SetActive(true);
        mainMenu.SetActive(false);
        SelectBackground.SetActive(true);
    }

    public void Training()
    {
        gameTraining = true;
        charMenu.SetActive(true);
        mainMenu.SetActive(false);
        SelectBackground.SetActive(true);
    }

    public void Options()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void ApplyChanges()
    {
        ReturnToMainmenu();
    }

    public void CancelChanges()
    {
        ReturnToMainmenu();
    }

    public void BackToChar()
    {
        charMenu.SetActive(true);
        stageMenu.SetActive(false);
        SelectBackground.SetActive(false);
    }

    public void BackToMenu()
    {
        ReturnToMainmenu();
    }

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void Continue()
    {
        if (gameVersus || gameTraining)
        {
            charMenu.SetActive(false);
            stageMenu.SetActive(true);
            SelectBackground.SetActive(false);
        }

        if (gameCampaign)
        {

        }
    }

    public void ReturnToMainmenu()
    {
        optionsMenu.SetActive(false);
        charMenu.SetActive(false);
        mainMenu.SetActive(true);
        stageMenu.SetActive(false);
        SelectBackground.SetActive(false);
        gameVersus = false;
        gameCampaign = false;
        gameTraining = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
