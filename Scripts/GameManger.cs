using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public static GameManger instance;
    [SerializeField] Text textScore;
    int score;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        textScore.text = score.ToString();
    }

    public void IncreaseScore()
    {
        score++;
            textScore.text = score.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game");
    }

  
}
