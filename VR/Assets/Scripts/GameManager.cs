using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class GameManager : MonoBehaviour
{
    [Header("籃球數量")]
    public Text textBallCount;
    [Header("分數")]
    public Text textScore;
    [Header("兩分球音效")]
    public AudioClip seundTwo;

    private AudioSource aud;
    private int ballCount = 6;
    private int score;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    public void UseBall(GameObject ball)
    {
        Destroy(ball.GetComponent<Throwable>());
        Destroy(ball.GetComponent<Interactable>());

        ballCount --;
        textBallCount.text = "橄欖球數量 : " + ballCount + " / 6";


    }
    private void OnTriggerEnter(Collider other)
    {
        score ++;
        textScore.text = "2分進球數 : " + score;
        aud.PlayOneShot(seundTwo);
    }

    public void Reaplay()
    {
        SceneManager.LoadScene("VR_Game");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
