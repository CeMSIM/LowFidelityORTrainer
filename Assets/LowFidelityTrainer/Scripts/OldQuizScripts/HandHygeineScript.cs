using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandHygeineScript : MonoBehaviour
{
    public GameObject HandHygeineOptionA;
    public GameObject HandHygeineOptionB;
    public GameObject HandHygeineOptionC;
    public GameObject HandHygeineOptionD;

    public GameObject HandHygeineOBA;
    public GameObject HandHygeineOBB;
    public GameObject HandHygeineOBC;
    public GameObject HandHygeineOBD;

    public GameObject exit;

    private int x;
    // Start is called before the first frame update
    void Start()
    {
        HandHygeineOBA.gameObject.SetActive(false);
        HandHygeineOBB.gameObject.SetActive(false);
        HandHygeineOBC.gameObject.SetActive(false);
        HandHygeineOBD.gameObject.SetActive(false);

        x = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (x == 1)
        {
            HandHygeineOBA.gameObject.SetActive(false);
            HandHygeineOBB.gameObject.SetActive(false);
            HandHygeineOBC.gameObject.SetActive(false);
            HandHygeineOBD.gameObject.SetActive(false);

        }
    }

    public void ChangeOptions()
    {
        x += 1;
    }

    public void MakeButtonsAppear()
    {
        HandHygeineOBA.gameObject.SetActive(true);
        HandHygeineOBB.gameObject.SetActive(true);
        HandHygeineOBC.gameObject.SetActive(true);
        HandHygeineOBD.gameObject.SetActive(true);
    }
}

