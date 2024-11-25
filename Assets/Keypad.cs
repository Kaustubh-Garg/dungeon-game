using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Gate;

    private string Answer = "4879";

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if (Ans.text == Answer)
        {
            Ans.text="Correct";
            Gate.SetBool("Open",true);
        }
        else
        {
            Ans.text="Failed";
            Gate.SetBool("Open",false);
        }
    }
}
