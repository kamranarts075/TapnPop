using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    
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
    }
}
