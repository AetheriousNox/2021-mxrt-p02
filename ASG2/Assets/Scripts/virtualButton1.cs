using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class virtualButton1 : MonoBehaviour
{

    public GameObject vbBtnObj;    //two gameObject to control virtual buttons when player click on it an event will occur.
    public GameObject vbBtnObjExit;
    public TextMesh texts;
    void Start()
    {
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);   //able to let virtual button detect if button have been pressed
        vbBtnObjExit.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressedExit);
        vbBtnObjExit.SetActive(false);
        texts.text = " ";
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)   //On button press set the button to active and deactivate the other button while also changing the text of said item
    {
        texts.text = "COVID-19 is a coronavirus \n which was first identified in Wuhan \n China 2019, currently it have a \n mortality rate of 0.05% in Singapore, \n its symptoms includes fever, cough, \n sore throat or sneezing.  ";
        vbBtnObjExit.SetActive(true);
        vbBtnObj.SetActive(false);
    }

    public void OnButtonPressedExit(VirtualButtonBehaviour vb) //same as above but disable the text
    {
        texts.text = " ";
        vbBtnObjExit.SetActive(false);
        vbBtnObj.SetActive(true);
    }
}