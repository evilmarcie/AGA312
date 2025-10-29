using TMPro;

public class Scoring : JMC
{
    
    TextMeshProUGUI scoreDifference;

    float lastRoundScore = 50;
    float thisRoundScore = 88;

    void GetScoreDifference()
    {
        scoreDifference.text = "Your Change Is:" + PercentageChange(lastRoundScore, thisRoundScore);
    }
}
