using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public GameObject optionPanel;
    public GameObject topPanel, MenuPanel;
    // Start is called before the first frame update
    public void optionsMenu()
    {
        optionPanel.SetActive(true);
        topPanel.SetActive(false);
        MenuPanel.SetActive(false);

    }
    public void Back()
    {
        optionPanel.SetActive(false);
        topPanel.SetActive(true);
        MenuPanel.SetActive(true);
    }
        

}

