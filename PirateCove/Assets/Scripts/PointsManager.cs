using UnityEngine;
using UnityEngine.UI;       // For Text
using TMPro;                // For the TextMesh Pro

public class PointsManager : MonoBehaviour
{
    private int points = 0;

    public Text LeftScoreTextBox;                   // Good old 'legacy' text box
    public TextMeshProUGUI RightScoreTextBox;       // TextMesh pro type text box

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftScoreTextBox.text = "Points: " + points;
        RightScoreTextBox.text = "Points: " + points;
    }

    // A custom method for things to call
    public void AddPoints(int numberOfPoints)
    {
        points += numberOfPoints;
    }
}
