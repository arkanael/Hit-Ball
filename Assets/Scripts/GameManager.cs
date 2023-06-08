using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject gameStartUI;

    public float ballBounceForce;

    private int score;
    public bool gameStarted;

    public float paddleMoveSpeed;

    public Text scoreBoard;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        scoreBoard.gameObject.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void ScoreUp()
    {
        score++;
        scoreBoard.text = score.ToString();
    }
   
}
