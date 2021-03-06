using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GoPanel;
    public string escena;
    public string escena3;

    public Text QuestionTxt;
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;

    private void Start()
    {
        totalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
    }
    public void retry()
    {
        if (score > 2)
        {
            SceneManager.LoadScene(escena);
            
        }
        else
        {
            SceneManager.LoadScene(escena3);
            
        }
        
    }
    void GameOver()
    {
        Quizpanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreTxt.text = score + "/" +  totalQuestions;
    }
    public void correct()
     {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    } 
    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }
    void SetAnswers()
    {
        for(int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswersScript>().isCorrect = false; 
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswersScript>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }
       
    }

}
