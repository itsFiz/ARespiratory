using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TruFalse : MonoBehaviour
{
    int range;
    int[] oldRange = { -1, -1, -1, -1, -1, -1, -1, -1 , -1, -1};
    int counter = 0;
    public static int score = 0;

    public Canvas GameCan;
    public Canvas WinCan;

    public Text questions;
    public Text answerA;
    public Text answerB;


    public Text ScoreText;
    public Text FinalScore;

    public AudioClip correctSound;
    public AudioClip wrongSound;

    private AudioSource audiox;

    bool Answ1;
    bool Answ2;


    public Button Button_1;
    public Button Button_2;




    // Use this for initialization
    void Start()
    {

        counter = 0;
        SelectingRange();
        audiox = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    void SelectingRange()
    {
        Button_1.interactable = true;
        Button_2.interactable = true;


        Button_1.GetComponent<Image>().color = Color.white;
        Button_2.GetComponent<Image>().color = Color.white;


        range = Random.Range(1, 10);

        for (int i = 0; i < oldRange.Length; i++)
        {
            if (range == oldRange[i])
            {
                range = Random.Range(1, 10);
                i = 0;
            }
            if (counter == oldRange.Length)
            {
                YouWon();
                break;

            }
        }

        oldRange[counter] = range;
        for (int i = 0; i < oldRange.Length; i++)
        {
            Debug.Log("Testing" + oldRange[i]);
        }
        SpawnQuestion();
        counter++;


    }

    void SpawnQuestion()
    {
        if (range == 1)
        {
            questions.text = "Bronchus is lined by pseudostratified columnar cells.";
            answerA.text = "True";
            answerB.text = "False";

            Answ1 = true;

        }

        if (range == 2)
        {
            questions.text = "Capillary endothelium forms the respiratory membrane.";
            answerA.text = "True";
            answerB.text = "False";

            Answ1 = true;

        }

        if (range == 3)
        {
            questions.text = "Nose, mouth, pharynx, larynx, trachea, bronchi are conducting airways.";
            answerA.text = "True";
            answerB.text = "False";

            Answ1 = true;

        }

        if (range == 4)
        {
            questions.text = "Ventilation is the process by which air enters and exits the lungs.";
            answerA.text = "True";
            answerB.text = "False";

            Answ1 = true;

        }

        if (range == 5)
        {
            questions.text = "Movement of the diaphragm downward and the chest wall outward creates a negative intrapleural pressure.";
            answerA.text = "True";
            answerB.text = "False";

            Answ1 = true;

        }

        if (range == 6)
        {
            questions.text = "Trachea, respiratory bronchioles, alveolar ducts, and alveoli are respiratory airways.";
            answerA.text = "True";
            answerB.text = "False";

            Answ2 = true;

        }

        if (range == 7)
        {
            questions.text = "Inspiration is a passive process that requires expansion of the thoracic cavity. ";
            answerA.text = "True";
            answerB.text = "False";

            Answ2 = true;

        }

        if (range == 8)
        {
            questions.text = "Expansion of the thoracic cavity is the result of diaphragmatic relaxation.";
            answerA.text = "True";
            answerB.text = "False";

            Answ2 = true;

        }

        if (range == 9)
        {
            questions.text = "Laplace’s law indicates that bigger alveoli has higher tendency to collapse.";
            answerA.text = "True";
            answerB.text = "False";

            Answ2 = true;

        }

        if (range == 10)
        {
            questions.text = "Gas exchange process across the pulmonary membrane requires ATP.";
            answerA.text = "True";
            answerB.text = "False";

            Answ2 = true;

        }

    }

    public void Button1()
    {
        DissableButton();

        if (Answ1 == true)
        {
            Button_1.GetComponent<Image>().color = Color.green;
            Invoke("SelectingRange", 1);
            Answ1 = false;
            AddScore();
            audiox.PlayOneShot(correctSound);

        }

        else
        {
            Button_1.GetComponent<Image>().color = Color.red;
            Invoke("SelectingRange", 2);
            audiox.PlayOneShot(wrongSound);
        }
    }

    public void Button2()
    {
        DissableButton();

        if (Answ2 == true)
        {
            Button_2.GetComponent<Image>().color = Color.green;
            Invoke("SelectingRange", 1);
            Answ2 = false;
            AddScore();
            audiox.PlayOneShot(correctSound);

        }

        else
        {
            Button_2.GetComponent<Image>().color = Color.red;
            Invoke("SelectingRange", 2);
            //MinusScore();
            audiox.PlayOneShot(wrongSound);
        }
    }




    void AddScore()
    {
        score = score + 1;
        ScoreText.text = "SCORE: " + score;

    }


    /*void MinusScore (){

        score = score - 1;
        ScoreText.text = "SCORE: " + score;

        if (score < 0)
        {
            score = 0;
            ScoreText.text = "SCORE: " + score;

        }

    }
    */

    void YouWon()
    {
        GameCan.gameObject.SetActive(false);
        WinCan.gameObject.SetActive(true);
        FinalScore.text = "Your score is " + score + "/10";
    }


    public void ButtonMenu()
    {
        SceneManager.LoadScene("");
    }


    void DissableButton()
    {
        Button_1.interactable = false;
        Button_2.interactable = false;


    }


}
