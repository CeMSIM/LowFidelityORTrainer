using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaskScript : MonoBehaviour
{
    public GameObject MaskOptionA;
    public GameObject MaskOptionB;
    public GameObject MaskOptionC;
    public GameObject MaskOptionD;

    public GameObject MaskOBA;
    public GameObject MaskOBB;
    public GameObject MaskOBC;
    public GameObject MaskOBD;

    public GameObject Canvas;
    public GameObject Exit;

    private int x;
    // Start is called before the first frame update
    void Start()
    {
        MaskOBA.gameObject.SetActive(false);
        MaskOBB.gameObject.SetActive(false);
        MaskOBC.gameObject.SetActive(false);
        MaskOBD.gameObject.SetActive(false);
        Exit.gameObject.SetActive(false);

        x = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (x == 1)
        {
            MaskOptionA.GetComponentInChildren<Text>().text = "Mask applied, move onto next step";
            MaskOptionB.GetComponentInChildren<Text>().text = "Mask applied, move onto next step";
            MaskOptionC.GetComponentInChildren<Text>().text = "Mask applied, move onto next step";
            MaskOptionD.GetComponentInChildren<Text>().text = "Mask applied, move onto next step";
        }
    }

    public void ChangeOptions()
    {
        x += 1;
    }

    public void MakeButtonsAppear ()
    {
        MaskOBA.gameObject.SetActive(true);
        MaskOBB.gameObject.SetActive(true);
        MaskOBC.gameObject.SetActive(true);
        MaskOBD.gameObject.SetActive(true);
        Exit.gameObject.SetActive(true);
    }
}
