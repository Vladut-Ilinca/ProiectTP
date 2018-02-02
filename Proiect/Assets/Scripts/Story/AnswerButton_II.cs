using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnswerButton_II : MonoBehaviour
{

    public Text answerText;

    private AnswerData_II answerData;
    private GameController_II gameController;

    // Use this for initialization
    void Start()
    {
        gameController = FindObjectOfType<GameController_II>();
    }

    public void Setup(AnswerData_II data)
    {
        answerData = data;
        answerText.text = answerData.answerText;
    }

    public void HandClick()
    {
        if (answerData.isCorrect == true)
            gameController.AnswerButtonClicked(answerData.isCorrect);
    }

}