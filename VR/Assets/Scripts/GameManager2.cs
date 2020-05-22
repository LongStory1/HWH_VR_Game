using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class GameManager2 : MonoBehaviour
{
    [Header("分數")]
    public Text textScore;
    [Header("十分球音效")]
    public AudioClip seundTen;

    private AudioSource add;
    private int score;

    private void Start()
    {
        add = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        score++;

        textScore.text = "10分進球數 : " + score;
        add.PlayOneShot(seundTen, 1.5f);
    }
}
