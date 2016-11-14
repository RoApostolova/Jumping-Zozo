using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IngameMenu : MonoBehaviour {

    public Image inGameMenu;
    public Button resume;
    public Button MainMenu;
    public Text resume1;
    public Text Mainmenu;

    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        inGameMenu = inGameMenu.GetComponent<Image>();
        resume = resume.GetComponent<Button>();
        MainMenu = MainMenu.GetComponent<Button>();
        resume1 = resume1.GetComponent<Text>();
        Mainmenu = Mainmenu.GetComponent<Text>();
        resume1.enabled = false;
        Mainmenu.enabled = false;
        inGameMenu.enabled = false;
        resume.enabled = false;
        MainMenu.enabled = false;

        

    }
    public void PausePress()
    {
        Time.timeScale = 0;
        inGameMenu.enabled = true;
        resume.enabled = true;
        MainMenu.enabled = true;
        resume1.enabled = true;
        Mainmenu.enabled = true;


    }
    public void Resume()
    {
        Start();
    }
    public void mainMenu()
    {
        Application.LoadLevel(0);
    }

    
}
