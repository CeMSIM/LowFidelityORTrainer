using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject N95OptionA;
    public GameObject N95OptionB;
    public GameObject N95OptionC;
    public GameObject N95OptionD;

    public GameObject N95OBA;
    public GameObject N95OBB;
    public GameObject N95OBC;
    public GameObject N95OBD;

    public GameObject Canvas;
    public GameObject Exit;

    public GameObject QuestText;

    public int N95;
    private int Mask;
    private int HandHygeine;
    private int Gown;
    private int Gloves;

    public bool Gametype;

    public GameObject N95Check;
    public GameObject MaskCheck;
    public GameObject GownCheck;
    public GameObject GlovesCheck;
    public GameObject HandHygeineCheck;
   
    private DoffingScript Doff;
    public int X;






    // Start is called before the first frame update
    void Start()
    {
        N95OBA.gameObject.SetActive(false);
        N95OBB.gameObject.SetActive(false);
        N95OBC.gameObject.SetActive(false);
        N95OBD.gameObject.SetActive(false);
        Exit.gameObject.SetActive(false);
        N95 = 0;
        HandHygeine = 0;
        Gown = 0;
        Mask = 0;
        Gloves = 0;



        
    }

    // Update is called once per frame
    void Update()
    {
        {

            if (N95 == 1 && Mask == 0 && HandHygeine == 0 && Gown == 0 && Gloves == 0 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What is the first step of applying the N95 Respirator?";
                N95OptionA.GetComponentInChildren<Text>().text = "Secure ear loops or ties/elastic bands at middle of head and neck";
                N95OptionB.GetComponentInChildren<Text>().text = "Secure ear loops or ties/elastic bands at top of head and neck";
                N95OptionC.GetComponentInChildren<Text>().text = "Secure ear loops or ties/elastic bands at  neck";
                N95OptionD.GetComponentInChildren<Text>().text = "Secure ear loops or ties/elastic bands at middle of head";
            }

                if (N95 == 2 && Mask == 0 && HandHygeine == 0 && Gown == 0 && Gloves == 0 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What is the next step?";
                N95OptionA.GetComponentInChildren<Text>().text = "Dispose of flexible band in hazardous waste";
                N95OptionB.GetComponentInChildren<Text>().text = "Dispose of flexible band";
                N95OptionC.GetComponentInChildren<Text>().text = "Fit flexible band to nose bridge";
                N95OptionD.GetComponentInChildren<Text>().text = "Fit flexible band to chin";
            }

            if (N95 == 3 && Mask == 0 && HandHygeine == 0 && Gown == 0 && Gloves == 0 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "Where do you fit the straps?";
                N95OptionA.GetComponentInChildren<Text>().text = "Fit around the neck";
                N95OptionB.GetComponentInChildren<Text>().text = "Fit snug to face";
                N95OptionC.GetComponentInChildren<Text>().text = "Fit snug behind the head";
                N95OptionD.GetComponentInChildren<Text>().text = "Fit snug to face and below chin";
            }

            if (N95 == 4 && Mask == 0 && HandHygeine == 0 && Gown == 0 && Gloves == 0 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What should you do after the straps are fit?";
                N95OptionA.GetComponentInChildren<Text>().text = "Ensure respirator fit";
                N95OptionB.GetComponentInChildren<Text>().text = "Continue";
                N95OptionC.GetComponentInChildren<Text>().text = "None of the Above";
                N95OptionD.GetComponentInChildren<Text>().text = ".";
            }

            if (N95 == 5 && Mask == 0 && HandHygeine == 0 && Gown == 0 && Gloves == 0 && X == 0)
            {
                Gown = 0;
                N95 = 0;
                HandHygeine = 0;
                Mask = 0;
                Gloves = 0;
                QuestText.GetComponentInParent<Text>().text = "N95 Respirator applied, select the next article of PPE to apply";
                N95OBA.gameObject.SetActive(false);
                N95OBB.gameObject.SetActive(false);
                N95OBC.gameObject.SetActive(false);
                N95OBD.gameObject.SetActive(false);
                Exit.gameObject.SetActive(false);




                N95Check.gameObject.SetActive(true);

            }

            if (N95 == 0 && Mask == 1 && HandHygeine == 0 && Gown == 0 && Gloves == 0 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What area of the face should be covered by the mask?";
                N95OptionA.GetComponentInChildren<Text>().text = "Make sure entire facial area is covered";
                N95OptionB.GetComponentInChildren<Text>().text = "Make sure entire mouth is covered";
                N95OptionC.GetComponentInChildren<Text>().text = "Make sure entire nose is covered";
                N95OptionD.GetComponentInChildren<Text>().text = "Make sure eyes and nose are covered";
            }

            if (N95 == 1 && Mask == 1 && HandHygeine == 0 && Gown == 0 && Gloves == 0 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "Mask applied, select the next PPE";
                N95OBA.gameObject.SetActive(false);
                N95OBB.gameObject.SetActive(false);
                N95OBC.gameObject.SetActive(false);
                N95OBD.gameObject.SetActive(false);
                Exit.gameObject.SetActive(false);

                MaskCheck.gameObject.SetActive(true);

                Gown = 0;
                N95 = 0;
                HandHygeine = 0;
                Mask = 0;
                Gloves = 0;
            }


            if (N95 == 0 && Mask == 0 && HandHygeine == 1 && Gown == 0 && Gloves == 0 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "Hands washed, select the next PPE";
                N95OBA.gameObject.SetActive(false);
                N95OBB.gameObject.SetActive(false);
                N95OBC.gameObject.SetActive(false);
                N95OBD.gameObject.SetActive(false);
                Exit.gameObject.SetActive(false);

                HandHygeineCheck.gameObject.SetActive(true);

                Gown = 0;
                N95 = 0;
                HandHygeine = 0;
                Mask = 0;
                Gloves = 0;
            }

            if (N95 == 0 && Mask == 0 && HandHygeine == 0 && Gown == 1 && Gloves == 0 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What areas of the body should be covered by the gown?";
                N95OptionA.GetComponentInChildren<Text>().text = "Fully cover torso from neck to knees";
                N95OptionB.GetComponentInChildren<Text>().text = "Fully cover torso from neck to thighs";
                N95OptionC.GetComponentInChildren<Text>().text = "Fully cover torso from neck to waist";
                N95OptionD.GetComponentInChildren<Text>().text = "Fully cover torso from neck to ankles";
            }

            if (N95 == 1 && Mask == 0 && HandHygeine == 0 && Gown == 1 && Gloves == 0 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "Where should the strap be fastened?";
                N95OptionA.GetComponentInChildren<Text>().text = "Fasten in the front of waist";
                N95OptionB.GetComponentInChildren<Text>().text = "Fasten in front of waist and neck";
                N95OptionC.GetComponentInChildren<Text>().text = "Fasten in back of waist";
                N95OptionD.GetComponentInChildren<Text>().text = "Fasten in back of waist and neck";
            }

            if (N95 == 2 && Mask == 0 && HandHygeine == 0 && Gown == 1 && Gloves == 0 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "Gown applied, select the next PPE";
                N95OBA.gameObject.SetActive(false);
                N95OBB.gameObject.SetActive(false);
                N95OBC.gameObject.SetActive(false);
                N95OBD.gameObject.SetActive(false);
                Exit.gameObject.SetActive(false);

                GownCheck.gameObject.SetActive(true);

                Gown = 0;
                N95 = 0;
                HandHygeine = 0;
                Mask = 0;
                Gloves = 0;
            }

            if (N95 == 0 && Mask == 0 && HandHygeine == 0 && Gown == 0 && Gloves == 1 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "How many gloves will you apply?";
                N95OptionA.GetComponentInChildren<Text>().text = "1";
                N95OptionB.GetComponentInChildren<Text>().text = "2";
                N95OptionC.GetComponentInChildren<Text>().text = "3";
                N95OptionD.GetComponentInChildren<Text>().text = "4";
            }

            if (N95 == 1 && Mask == 0 && HandHygeine == 0 && Gown == 0 && Gloves == 1 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "How far should the gloves extend?";
                N95OptionA.GetComponentInChildren<Text>().text = "Extend to forearm";
                N95OptionB.GetComponentInChildren<Text>().text = "Extend until comfortable";
                N95OptionC.GetComponentInChildren<Text>().text = "Extend to cover wrist";
                N95OptionD.GetComponentInChildren<Text>().text = "Extend to cover wrist of isolation gown";
            }

            if (N95 == 2 && Mask == 0 && HandHygeine == 0 && Gown == 0 && Gloves == 1 && X == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "PPE applied, move onto the next section.";
                N95OBA.gameObject.SetActive(false);
                N95OBB.gameObject.SetActive(false);
                N95OBC.gameObject.SetActive(false);
                N95OBD.gameObject.SetActive(false);
                Exit.gameObject.SetActive(false);

                GlovesCheck.gameObject.SetActive(true);

                Gown = 0;
                N95 = 0;
                HandHygeine = 0;
                Mask = 0;
                Gloves = 0;
            }
        }
    }

    public void ChangeOptions()
    {
        N95 += 1;
    }

    public void ChangeOptionsMask()
    {
        Mask += 1;
    }

    public void ChangeOptionsHandHygeine()
    {
        HandHygeine += 1;
    }

    public void ChangeOptionsGown()
    {
        Gown += 1;
    }

    public void ChangeOptionsGloves()
    {
        Gloves += 1;
    }
    public void MakeButtonAppear()
    {
        N95OBA.gameObject.SetActive(true);
        N95OBB.gameObject.SetActive(true);
        N95OBC.gameObject.SetActive(true);
        N95OBD.gameObject.SetActive(true);
        Exit.gameObject.SetActive(true);
        Canvas.gameObject.SetActive(true);
    }

    public void ExitButton()
    {
        N95OBA.gameObject.SetActive(false);
        N95OBB.gameObject.SetActive(false);
        N95OBC.gameObject.SetActive(false);
        N95OBD.gameObject.SetActive(false);
        Exit.gameObject.SetActive(false);
        QuestText.GetComponentInParent<Text>().text = "Select the next item of PPE";
        Gown = 0;
        N95 = 0;
        HandHygeine = 0;
        Mask = 0;
        Gloves = 0;
        

    }

    public void ChangeX()
    {
        X += 1;
    }

    public void StartTutorial()
    {
        Gametype = false;
    }
}
