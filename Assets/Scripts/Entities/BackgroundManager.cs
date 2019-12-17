using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundManager : MonoBehaviour
{
    public string selectedBackground = "";
    public int backgroundCounter;

    public string[] backgroundScene = new string[]
    {
        "Scene0",
        "Scene1",
        "Scene2",
        "Scene3",
        "Scene4",
        "Scene5",
        "Scene6",
        "Scene7",
        "Scene8",
        "Scene9"
    };
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);

        backgroundCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void sceneBackgroundManager()
    {
        Debug.Log("sceneBackgroundManager");

        if (backgroundCounter < backgroundScene.Length)
        {
            backgroundCounter ++;
        }

        if (backgroundCounter == backgroundScene.Length)
        {
            backgroundCounter = 0;
        }

        selectedBackground = backgroundScene[backgroundCounter];
    }

    private void sceneBackgroundLoad()
    {
        Debug.Log("sceneBackgroundLoad");

        SceneManager.LoadScene(selectedBackground);
    }
}
