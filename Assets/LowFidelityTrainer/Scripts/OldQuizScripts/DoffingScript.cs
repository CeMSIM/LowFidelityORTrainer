using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoffingScript : MonoBehaviour
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

    public int N95R;
    private int MaskR;
    private int HandHygeineR;
    private int GownR;
    private int GlovesR;

    public GameObject N95Check;
    public GameObject MaskCheck;
    public GameObject GownCheck;
    public GameObject GlovesCheck;
    public GameObject HandHygeineCheck;
    public GameObject AnteroomCheck;

    public List<string> Answers;

    // Start is called before the first frame update
    void Start()
    {
        N95OBA.gameObject.SetActive(false);
        N95OBB.gameObject.SetActive(false);
        N95OBC.gameObject.SetActive(false);
        N95OBD.gameObject.SetActive(false);
        Exit.gameObject.SetActive(false);
        N95R = 0;
        HandHygeineR = 0;
        GownR = 0;
        MaskR = 0;
        GlovesR = 0;

        N95Check.gameObject.SetActive(false);
        MaskCheck.gameObject.SetActive(false);
        GlovesCheck.gameObject.SetActive(false);
        GownCheck.gameObject.SetActive(false);
        HandHygeineCheck.gameObject.SetActive(false);
        AnteroomCheck.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (N95R == 1 && MaskR == 0 && HandHygeineR == 0 && GownR == 0 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What is the first step in removing the N95 Respirator?";
                N95OptionA.GetComponentInChildren<Text>().text = "Grasp either top ties/ elastics of the mask, followed by the ones at the bottom";
                N95OptionB.GetComponentInChildren<Text>().text = "Grasp either bottom ties/elastics of the mask, followed by the ones at the top";
                N95OptionC.GetComponentInChildren<Text>().text = "Grasp both ties at the same time";
                N95OptionD.GetComponentInChildren<Text>().text = "Have a partner grasp all ties";
            }

            if (N95R == 2 && MaskR == 0 && HandHygeineR == 0 && GownR == 0 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "How should the respirator be removed?";
                N95OptionA.GetComponentInChildren<Text>().text = "Remove while only touching the sides";
                N95OptionB.GetComponentInChildren<Text>().text = "Have partner remove";
                N95OptionC.GetComponentInChildren<Text>().text = "Remove while only touching the front";
                N95OptionD.GetComponentInChildren<Text>().text = "Remove without touching the front";
            }

            if (N95R == 3 && MaskR == 0 && HandHygeineR == 0 && GownR == 0 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What should be done after removal?";
                N95OptionA.GetComponentInChildren<Text>().text = "Discard into trash can";
                N95OptionB.GetComponentInChildren<Text>().text = "Discard into a soiled bin";
                N95OptionC.GetComponentInChildren<Text>().text = "Discard into a waste container";
                N95OptionD.GetComponentInChildren<Text>().text = "Do not dispose";
            }

            if (N95R == 4 && MaskR == 0 && HandHygeineR == 0 && GownR == 0 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "N95 Respirator removed, move onto the next article of PPE to remove";
                N95OBA.gameObject.SetActive(false);
                N95OBB.gameObject.SetActive(false);
                N95OBC.gameObject.SetActive(false);
                N95OBD.gameObject.SetActive(false);
                Exit.gameObject.SetActive(false);

                GownR = 0;
                N95R = 0;
                HandHygeineR = 0;
                MaskR = 0;
                GlovesR = 0;

                N95Check.gameObject.SetActive(true);
            }

            if (N95R == 0 && MaskR == 1 && HandHygeineR == 0 && GownR == 0 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What is the first step in removing the mask?";
                N95OptionA.GetComponentInChildren<Text>().text = "Grasp either top ties/ elastics of the mask, followed by the ones at the bottom";
                N95OptionB.GetComponentInChildren<Text>().text = "Grasp either both ear loops or bottom ties/elastics of the mask, followed by the ones on top";
                N95OptionC.GetComponentInChildren<Text>().text = "Grasp both ties at the same time";
                N95OptionD.GetComponentInChildren<Text>().text = "Have a partner grasp all ties";

            }

            if (N95R == 1 && MaskR == 1 && HandHygeineR == 0 && GownR == 0 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "How should the mask be removed?";
                N95OptionA.GetComponentInChildren<Text>().text = "Remove while only touching the sides";
                N95OptionB.GetComponentInChildren<Text>().text = "Have partner remove";
                N95OptionC.GetComponentInChildren<Text>().text = "Remove while only touching the front";
                N95OptionD.GetComponentInChildren<Text>().text = "Remove without touching the front";
            }
            if (N95R == 2 && MaskR == 1 && HandHygeineR == 0 && GownR == 0 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What should be done after removal?";
                N95OptionA.GetComponentInChildren<Text>().text = "Discard into trash can";
                N95OptionB.GetComponentInChildren<Text>().text = "Discard into a soiled bin";
                N95OptionC.GetComponentInChildren<Text>().text = "Discard into a waste container";
                N95OptionD.GetComponentInChildren<Text>().text = "Do not dispose";
            }

            if (N95R == 3 && MaskR == 1 && HandHygeineR == 0 && GownR == 0 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "Mask removed, move onto the next article of PPE to remove";
                N95OBA.gameObject.SetActive(false);
                N95OBB.gameObject.SetActive(false);
                N95OBC.gameObject.SetActive(false);
                N95OBD.gameObject.SetActive(false);
                Exit.gameObject.SetActive(false);

                GownR = 0;
                N95R = 0;
                HandHygeineR = 0;
                MaskR = 0;
                GlovesR = 0;

                MaskCheck.gameObject.SetActive(true);
            }


            if (N95R == 0 && MaskR == 0 && HandHygeineR == 1 && GownR == 0 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "Make sure you wash and sanitize thoroughly. PPE removal is complete, you may now exit the simulator.";
                N95OBA.gameObject.SetActive(false);
                N95OBB.gameObject.SetActive(false);
                N95OBC.gameObject.SetActive(false);
                N95OBD.gameObject.SetActive(false);
                Exit.gameObject.SetActive(false);

                GownR = 0;
                N95R = 0;
                HandHygeineR = 0;
                MaskR = 0;
                GlovesR = 0;

                HandHygeineCheck.gameObject.SetActive(true);
            }

            if (N95R == 0 && MaskR == 0 && HandHygeineR == 0 && GownR == 1 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What is the first step in removing the gown?";
                N95OptionA.GetComponentInChildren<Text>().text = "Roll up your sleeves";
                N95OptionB.GetComponentInChildren<Text>().text = "Carefully pull the gown off you, without touch your body with the outside";
                N95OptionC.GetComponentInChildren<Text>().text = "Unfasten gown ties, taking care that sleeves don't contact your body when reaching for ties";
                N95OptionD.GetComponentInChildren<Text>().text = "Fold the gown upwards";
            }

            if (N95R == 1 && MaskR == 0 && HandHygeineR == 0 && GownR == 1 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "Where should the gown be moved?";
                N95OptionA.GetComponentInChildren<Text>().text = "Pull gown towards from neck and shoulders, touching outside of gown only";
                N95OptionB.GetComponentInChildren<Text>().text = "Pull gown towards neck and shoulders, touching inside of gown only";
                N95OptionC.GetComponentInChildren<Text>().text = "Pull gown away from neck and shoulders, touching inside of gown only";
                N95OptionD.GetComponentInChildren<Text>().text = "Pull gown away from neck and shoulders, touching outside of gown only";
            }

            if (N95R == 2 && MaskR == 0 && HandHygeineR == 0 && GownR == 1 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What should you do once the gown is folded?";
                N95OptionA.GetComponentInChildren<Text>().text = "Discard gown";
                N95OptionB.GetComponentInChildren<Text>().text = "Turn gown inside out";
                N95OptionC.GetComponentInChildren<Text>().text = "Sanitize gown";
                N95OptionD.GetComponentInChildren<Text>().text = "Wash gown";
            }

            if (N95R == 3 && MaskR == 0 && HandHygeineR == 0 && GownR == 1 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "What should you do after the gown is inside out?";
                N95OptionA.GetComponentInChildren<Text>().text = "Fold or roll into a bundle and discard the soiled linen bin in operating room";
                N95OptionB.GetComponentInChildren<Text>().text = "Fold or roll into a bundle and discard the soiled linen bin in trash room";
                N95OptionC.GetComponentInChildren<Text>().text = "Fold or roll into a bundle and discard the soiled linen bin in outside room";
                N95OptionD.GetComponentInChildren<Text>().text = "Fold or roll into a bundle and discard the soiled linen bin in patient room";
            }

            if (N95R == 4 && MaskR == 0 && HandHygeineR == 0 && GownR == 1 && GlovesR == 0)
            {
                QuestText.GetComponentInParent<Text>().text = "Gown has been removed, select the next article of PPE to remove";
                N95OBA.gameObject.SetActive(false);
                N95OBB.gameObject.SetActive(false);
                N95OBC.gameObject.SetActive(false);
                N95OBD.gameObject.SetActive(false);
                Exit.gameObject.SetActive(false);

                GownR = 0;
                N95R = 0;
                HandHygeineR = 0;
                MaskR = 0;
                GlovesR = 0;

                GownCheck.gameObject.SetActive(true);
            }

            if (N95R == 0 && MaskR == 0 && HandHygeineR == 0 && GownR == 0 && GlovesR == 1)
            {
                QuestText.GetComponentInParent<Text>().text = "What is the first step in removing gloves?";
                N95OptionA.GetComponentInChildren<Text>().text = "Have a partner remove one glove";
                N95OptionB.GetComponentInChildren<Text>().text = "Using an ungloved hand, rasp the palm area of the other gloved hand and peel off the first glove";
                N95OptionC.GetComponentInChildren<Text>().text = "Have a partner remove both gloves";
                N95OptionD.GetComponentInChildren<Text>().text = "Using a gloved hand, rasp the palm area of the other gloved hand and peel off the first glove";
            }

            if (N95R == 1 && MaskR == 0 && HandHygeineR == 0 && GownR == 0 && GlovesR == 1)
            {
                QuestText.GetComponentInParent<Text>().text = "Where should the first removed glove be placed?";
                N95OptionA.GetComponentInChildren<Text>().text = "In the disposal bin";
                N95OptionB.GetComponentInChildren<Text>().text = "Hold removed glove in gloved hand";
                N95OptionC.GetComponentInChildren<Text>().text = "On the operating table";
                N95OptionD.GetComponentInChildren<Text>().text = "In the gown pocket";
            }
            
            if (N95R == 2 && MaskR == 0 && HandHygeineR == 0 && GownR == 0 && GlovesR == 1)
            {
                QuestText.GetComponentInParent<Text>().text = "What is done once the first glove is removed?";
                N95OptionA.GetComponentInChildren<Text>().text = "Slide fingers of ungloved hand under remaining glove at wrist and peel off second glove over first glove";
                N95OptionB.GetComponentInChildren<Text>().text = "Peel the glove off from the top using your ungloved hand";
                N95OptionC.GetComponentInChildren<Text>().text = "Use a hook to go underneath your gloved hand and remove";
                N95OptionD.GetComponentInChildren<Text>().text = "None of the above";
            }

            if (N95R == 3 && MaskR == 0 && HandHygeineR == 0 && GownR == 0 && GlovesR == 1)
            {
                QuestText.GetComponentInParent<Text>().text = "Where should the gloves be disposed of?";
                N95OptionA.GetComponentInChildren<Text>().text = "In your pocket";
                N95OptionB.GetComponentInChildren<Text>().text = "Any garbage can";
                N95OptionC.GetComponentInChildren<Text>().text = "The patient rooom";
                N95OptionD.GetComponentInChildren<Text>().text = "None of the above";
            }

            if (N95R == 4 && MaskR == 0 && HandHygeineR == 0 && GownR == 0 && GlovesR == 1)
            {
                QuestText.GetComponentInParent<Text>().text = "Gloves have been properly removed, select the next article of PPE to remove";
                N95OBA.gameObject.SetActive(false);
                N95OBB.gameObject.SetActive(false);
                N95OBC.gameObject.SetActive(false);
                N95OBD.gameObject.SetActive(false);
                Exit.gameObject.SetActive(false);

                GownR = 0;
                N95R = 0;
                HandHygeineR = 0;
                MaskR = 0;
                GlovesR = 0;

                GlovesCheck.gameObject.SetActive(true);
            }
        }
    }


    public void ChangeOptionsR()
    {
        N95R += 1;
    }

    public void ChangeOptionsMask()
    {
        MaskR = 1;
    }

    public void ChangeOptionsHandHygeine()
    {
        HandHygeineR += 1;
    }

    public void ChangeOptionsGown()
    {
        GownR += 1;
    }

    public void ChangeOptionsGloves()
    {
        GlovesR += 1;
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
        GownR = 0;
        N95R = 0;
        HandHygeineR = 0;
        MaskR = 0;
        GlovesR = 0;


    }

    public void SaveAnswers()
    {
        Answers.Add(N95OptionA.GetComponentInChildren<Text>().text);
        Debug.Log(Answers);

    }

    public void BlockDoffing()
    {
        N95R += 25;
    }

    public void AllowDoffing()
    {
        N95R = 0;
    }
}
