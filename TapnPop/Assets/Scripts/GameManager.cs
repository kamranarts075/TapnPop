using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject restartButton;
    
    int score = 0;
    
    void Update()
    {
        
    }

    public void ScoreUp()
    {
        score++;

        if (score >= 5)
        {
            Win();
        }
    }

    void Win()
    {
        winText.SetActive(true);
        restartButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
