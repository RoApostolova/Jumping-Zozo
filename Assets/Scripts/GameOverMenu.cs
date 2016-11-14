using UnityEngine;
using System.Collections;

public class GameOverMenu : MonoBehaviour {

    public void PlayAgainPressed()
    {
        Application.LoadLevel(1);
    }
    public void MeinMenuPressed()
    {
        Application.LoadLevel(0);
    }
}
