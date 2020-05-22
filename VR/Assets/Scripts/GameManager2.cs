using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    [Header("分數")]
    public Text textScore;

    private int score;

    private void OnTriggerEnter(Collider other)
    {
        score++;

        textScore.text = "10分進球數 : " + score;
    }
}
