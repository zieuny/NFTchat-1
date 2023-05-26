using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MintingManager : MonoBehaviour
{
    public GameObject MintingView;
    
    public RawImage img;
    public InputField input_name;
    public Button button_minting;

    private string na = "hi";

    public void MintingButtonClick()
    {
        if(input_name.text == na)
        {
            Debug.Log("Success");
            MintingView.SetActive(false);
        }
        else Debug.Log("Fail");
    }
}
