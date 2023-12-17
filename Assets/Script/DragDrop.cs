using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour
{

    public bool Checked1 = false;
    public bool Checked2 = false;
    public bool Checked3 = false;
    public bool Checked4 = false;
    public bool Checked5 = false;
    public bool Checked6 = false;
    public bool Checked7 = false;
    public bool Checked8 = false;
    public bool Checked9 = false;
    public bool Checked10 = false;

    public GameObject wrong1;
    public GameObject right1;
    public GameObject wrong2;
    public GameObject right2;
    public GameObject wrong3;
    public GameObject right3;
    public GameObject wrong4;
    public GameObject right4;
    public GameObject wrong5;
    public GameObject right5;
    public GameObject wrong6;
    public GameObject right6;
    public GameObject wrong7;
    public GameObject right7;
    public GameObject wrong8;
    public GameObject right8;
    public GameObject wrong9;
    public GameObject right9;
    public GameObject wrong10;
    public GameObject right10;

    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject Box4;
    public GameObject Box5;
    public GameObject Box6;
    public GameObject Box7;
    public GameObject Box8;
    public GameObject Box9;
    public GameObject Box10;

    public int Score1, Score2, Score3, Score4, Score5, Score6, Score7, Score8, Score9, Score10;
    public Text ScoreText;
    public int ScoreTotal = 0;

    // Use this for initialization
    void Start()
    {

        wrong1.SetActive(false);
        right1.SetActive(false);
        wrong2.SetActive(false);
        right2.SetActive(false);
        wrong3.SetActive(false);
        right3.SetActive(false);
        wrong4.SetActive(false);
        right4.SetActive(false);
        wrong5.SetActive(false);
        right5.SetActive(false);
        wrong6.SetActive(false);
        right6.SetActive(false);
        wrong7.SetActive(false);
        right7.SetActive(false);
        wrong8.SetActive(false);
        right8.SetActive(false);
        wrong9.SetActive(false);
        right9.SetActive(false);
        wrong10.SetActive(false);
        right10.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Drag1()
    {
        GameObject.Find("ans1").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop1()
    {
        GameObject b1 = GameObject.Find("q1");
        //GameObject b1 = Box1;
        float distance = Vector3.Distance(GameObject.Find("ans1").transform.position, b1.transform.position);
        if (distance < 40)
        {

            GameObject.Find("ans1").transform.position = b1.transform.position;
            Checked1 = true;
            Score1 = 2;
            // print("Drop the answer");
        }
        else if (GameObject.Find("ans1").transform.position != b1.transform.position)
        {
            Checked1 = false;
            Score1 = 0;
        }
        print("Drop the answer");
    }

    public void Drag2()
    {
        GameObject.Find("ans2").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop2()
    {
        GameObject wb2 = GameObject.Find("q2");
        float distance = Vector3.Distance(GameObject.Find("ans2").transform.position, wb2.transform.position);
        if (distance < 40)
        {

            GameObject.Find("ans2").transform.position = wb2.transform.position;
            Checked2 = true;
            Score2 = 2;
        }
        if (GameObject.Find("ans2").transform.position != wb2.transform.position)
        {
            Checked2 = false;
            Score2 = 0;
        }
    }

    public void Drag3()
    {
        GameObject.Find("ans3").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop3()
    {
        GameObject wb3 = GameObject.Find("q3");
        float distance = Vector3.Distance(GameObject.Find("ans3").transform.position, wb3.transform.position);
        if (distance < 40)
        {

            GameObject.Find("ans3").transform.position = wb3.transform.position;
            Checked3 = true;
            Score3 = 2;
        }
        if (GameObject.Find("ans3").transform.position != wb3.transform.position)
        {
            Checked3 = false;
            Score3 = 0;
        }
    }

    public void Drag4()
    {
        GameObject.Find("ans4").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop4()
    {
        GameObject wb4 = GameObject.Find("q4");
        float distance = Vector3.Distance(GameObject.Find("ans4").transform.position, wb4.transform.position);
        if (distance < 40)
        {

            GameObject.Find("ans4").transform.position = wb4.transform.position;
            Checked4 = true;
            Score4 = 2;
        }
        if (GameObject.Find("ans4").transform.position != wb4.transform.position)
        {
            Checked4 = false;
            Score4 = 0;
        }
    }

    public void Drag5()
    {
        GameObject.Find("ans5").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop5()
    {
        GameObject wb5 = GameObject.Find("q5");
        float distance = Vector3.Distance(GameObject.Find("ans5").transform.position, wb5.transform.position);
        if (distance < 40)
        {

            GameObject.Find("ans5").transform.position = wb5.transform.position;
            Checked5 = true;
            Score5 = 2;
        }
        if (GameObject.Find("ans5").transform.position != wb5.transform.position)
        {
            Checked5 = false;
            Score5 = 0;
        }
    }

    public void Drag6()
    {
        GameObject.Find("ans6").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop6()
    {
        GameObject wb6 = GameObject.Find("q6");
        float distance = Vector3.Distance(GameObject.Find("ans6").transform.position, wb6.transform.position);
        if (distance < 40)
        {

            GameObject.Find("ans6").transform.position = wb6.transform.position;
            Checked6 = true;
            Score6 = 2;
        }
        if (GameObject.Find("ans6").transform.position != wb6.transform.position)
        {
            Checked6 = false;
            Score6 = 0;
        }
    }

    public void Drag7()
    {
        GameObject.Find("ans7").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop7()
    {
        GameObject wb7 = GameObject.Find("q7");
        float distance = Vector3.Distance(GameObject.Find("ans7").transform.position, wb7.transform.position);
        if (distance < 40)
        {

            GameObject.Find("ans7").transform.position = wb7.transform.position;
            Checked7 = true;
            Score7 = 2;
        }
        if (GameObject.Find("ans7").transform.position != wb7.transform.position)
        {
            Checked7 = false;
            Score7 = 0;
        }
    }

    public void Drag8()
    {
        GameObject.Find("ans8").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop8()
    {
        GameObject wb8 = GameObject.Find("q8");
        float distance = Vector3.Distance(GameObject.Find("ans8").transform.position, wb8.transform.position);
        if (distance < 40)
        {

            GameObject.Find("ans8").transform.position = wb8.transform.position;
            Checked8 = true;
            Score8 = 2;
        }
        if (GameObject.Find("ans8").transform.position != wb8.transform.position)
        {
            Checked8 = false;
            Score8 = 0;
        }
    }

    public void Drag9()
    {
        GameObject.Find("ans9").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop9()
    {
        GameObject wb9 = GameObject.Find("q9");
        float distance = Vector3.Distance(GameObject.Find("ans9").transform.position, wb9.transform.position);
        if (distance < 40)
        {

            GameObject.Find("ans9").transform.position = wb9.transform.position;
            Checked9 = true;
            Score9 = 2;
        }
        if (GameObject.Find("ans9").transform.position != wb9.transform.position)
        {
            Checked4 = false;
            Score9 = 0;
        }
    }

    public void Drag10()
    {
        GameObject.Find("ans10").transform.position = Input.mousePosition;
        print("We are dragging the Mouse");

    }

    public void Drop10()
    {
        GameObject wb10 = GameObject.Find("q10");
        float distance = Vector3.Distance(GameObject.Find("ans10").transform.position, wb10.transform.position);
        if (distance < 40)
        {

            GameObject.Find("ans10").transform.position = wb10.transform.position;
            Checked10 = true;
            Score10 = 2;
        }
        if (GameObject.Find("ans10").transform.position != wb10.transform.position)
        {
            Checked10 = false;
            Score10 = 0;
        }
    }



    public void Submit()
    {
        if (Checked1 == true)
        {
            right1.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked1 == false)
        {
            wrong1.SetActive(true);
        }

        if (Checked2 == true)
        {
            right2.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked2 == false)
        {
            wrong2.SetActive(true);
        }

        if (Checked3 == true)
        {
            right3.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked3 == false)
        {
            wrong3.SetActive(true);
        }

        if (Checked4 == true)
        {
            right4.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked4 == false)
        {
            wrong4.SetActive(true);
        }

        if (Checked5 == true)
        {
            right5.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked5 == false)
        {
            wrong5.SetActive(true);
        }

        if (Checked6 == true)
        {
            right6.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked6 == false)
        {
            wrong6.SetActive(true);
        }

        if (Checked7 == true)
        {
            right7.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked7 == false)
        {
            wrong7.SetActive(true);
        }

        if (Checked8 == true)
        {
            right8.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked8 == false)
        {
            wrong8.SetActive(true);
        }

        if (Checked9 == true)
        {
            right9.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked9 == false)
        {
            wrong9.SetActive(true);
        }


        if (Checked10 == true)
        {
            right10.SetActive(true);
            print("Correct Answer");
        }

        else if (Checked10 == false)
        {
            wrong10.SetActive(true);
        }


        if (Checked1 == true && Checked2 == true && Checked3 == true && Checked4 == true && Checked5 == true && Checked6 == true && Checked7 == true && Checked8 == true && Checked9 == true && Checked10 == true)
        {
            ScoreTotal = Score1 + Score2 + Score3 + Score4 + Score5 + Score6 + Score7 + Score8 + Score9 + Score10;

        }
        else
        {

            ScoreTotal = Score1 + Score2 + Score3 + Score4 + Score5 + Score6 + Score7 + Score8 + Score9 + Score10;
        }

        ScoreText.text = "SCORE :" + ScoreTotal;
    }
}