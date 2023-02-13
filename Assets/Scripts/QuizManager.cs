using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QnA> qna;
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionTxt;

    // Start is called before the first frame update
    private void Start()
    {
        generateQuestion();
    }

    public void correct()
    {
        qna.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswer()
    {
        for(int i = 0; i < options.Length; i++) 
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = qna[currentQuestion].Answers[i];

            if(qna[currentQuestion].CorrectAnswer == i+1) 
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        currentQuestion = Random.Range(0, qna.Count);
        QuestionTxt.text = qna[currentQuestion].Question;
        SetAnswer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
