using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public int highScore;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI nameInput;
    public TextMeshProUGUI highScoreName;

    // Start is called before the first frame update
    void Start()
    {
        MainManager.Instance.LoadScore();
        highScore = MainManager.Instance.highScore;
        highScoreText.text = "High Score: " + highScore;
        highScoreName.text = "Name: " + MainManager.Instance.highScoreName;
    }

    public void StartNew() {
        MainManager.Instance.playerName = nameInput.text; 
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        MainManager.Instance.SaveScore();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
