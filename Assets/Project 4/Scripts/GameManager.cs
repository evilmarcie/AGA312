using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int valueL;
    int valueR;
    public GameObject numberGeneratorL;
    public GameObject numberGeneratorR;
    public GameObject menu;
    public GameObject gameElements;
    public GameObject gameOver;
    [SerializeField] TextMeshProUGUI timerText;
    float remainingTime = 3;

    public void CompareValuesL()
    {
        valueL = numberGeneratorL.GetComponent<RandomNumberGenerator>().randomNumber;
        valueR = numberGeneratorR.GetComponent<RandomNumberGenerator>().randomNumber;
        
        if (valueL > valueR)
        {
            generateNewNumbers();
        }

        else
        {
            GameOver();
        }
    }

     public void CompareValuesR()
    {
        valueL = numberGeneratorL.GetComponent<RandomNumberGenerator>().randomNumber;
        valueR = numberGeneratorR.GetComponent<RandomNumberGenerator>().randomNumber;
        
        if (valueR > valueL)
        {
            generateNewNumbers();
        }

        else
        {
            GameOver();
        }
    }

    public void StartGame()
    {
        menu.SetActive(false);
        gameElements.SetActive(true);
        generateNewNumbers();

    }
    
    public void generateNewNumbers()
    {
        numberGeneratorL.GetComponent<RandomNumberGenerator>().GenerateRandomNumber();
        numberGeneratorR.GetComponent<RandomNumberGenerator>().GenerateRandomNumber();
        remainingTime = 3;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        gameElements.SetActive(false);
    }

    public void Reset()
    {
        gameOver.SetActive(false);
        gameElements.SetActive(true);
        generateNewNumbers();
        remainingTime = 3;
    }

     void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            GameOver();
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

}

