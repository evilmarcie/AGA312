using UnityEngine;

public class JMC : MonoBehaviour
{
    [HideInInspector]
    public float globalTweenTime = 0.5f;

    public bool IsGameOver(int lives)
    {
        return lives == 0;
    }

    public static float PercentageChange(float scoreOne, float scoreTwo)
    {
        float change = scoreTwo - scoreOne;
        return change / scoreOne * 100;
    }
}
