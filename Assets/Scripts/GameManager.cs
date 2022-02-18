using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score;
    public Text scoreText;

    public GameObject gameStartUI;

    public static GameManager instance;
    void Awake()
    {
        instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }

    // kun peli alkaa
    public void GameStart()
    {
        gameStartUI.SetActive(false); // deaktivoidaan alkumenu
        scoreText.gameObject.SetActive(true); // aktivoidaan scoreText
    }





}
