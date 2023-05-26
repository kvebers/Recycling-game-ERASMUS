using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance { get; private set; }

    public int MaxLives = 3;
    public int StartingPoints = 0;

    public TextMeshProUGUI livesText;
    public TextMeshProUGUI pointsText;

    private int currentLives;
    private int currentPoints;
    public int CurrentPoints
    {
        get { return currentPoints; }
        set
        {
            
            currentPoints = currentPoints++;
            pointsText.text = "Points: " + currentPoints.ToString();
        }
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void RestartScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    private void Start()
    {
        currentLives = MaxLives;
        currentPoints = StartingPoints;

        livesText.text = "Lives: " + currentLives.ToString();
        pointsText.text = "Points: " + currentPoints.ToString();
    }

    public void IncreasePoints(int value)
    {
        currentPoints += value;
        pointsText.text = "Points: " + currentPoints.ToString();
    }

    public void DecLifePoints(int value)
    {
        currentLives = currentLives - value;
        livesText.text = "Lives: " + currentLives.ToString();
        if (currentLives <= 0)
        {
            RestartScene();
            SceneManager.LoadScene("Intro");
        }
    }
}