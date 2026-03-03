using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{

    private int Score = 0;

    [SerializeField]
    private TextMeshProUGUI text;


    public void IncreaseScore()
    {
        Score++;

        Debug.Log("Score: " + Score);
        text.text = "Score: " + Score;
    }
}
