using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
        Debug.Log("Hello World!");

        PrintFixedText();
        PrintInputText("PrintInputText::Hello World!");
        PrintInputText(GetFixedText());
        PrintInputText(GetTextFromInputText("Hello World!"));
    }

    void PrintFixedText() 
    {
        print("PrintFixedText::Hello World!");
    }

    void PrintInputText(string inputText)
    {
        print(inputText);
    }

    string GetFixedText()
    {
        return "GetFixedText::Hello World!";
    }

    string GetTextFromInputText(string inputText)
    {
        return "GetTextFromInputText::" + inputText;
    }
}