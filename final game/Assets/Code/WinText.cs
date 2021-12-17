using System.ComponentModel.Design;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class WinText : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        /* 
        Commander, you did it. 
        The alien race has been destroyed. 
        All is well in the Universe.
        You are once again the All-Knowing, All-Fearing Captain of the finest vessel in the solar system.  
        Let us toast our victory to you.
        */

        dialogTexts.Add(new DialogData("Commander, you did it. The earth is saved.", "Shipmate"));

        dialogTexts.Add(new DialogData("The alien race has been destroyed. ", "Shipmate"));
        
        dialogTexts.Add(new DialogData("You are once again the All-Knowing, All-Fearing Captain of the finest vessel in the solar system.  ", "Shipmate"));

        dialogTexts.Add(new DialogData("Let us toast our victory to you.", "Shipmate"));

        var Text1 = new DialogData("What do you want to do now?");

        Text1.SelectList.Add("Restart", "Restart");
        Text1.SelectList.Add("Home", "Home");
        Text1.SelectList.Add("Quit", "Quit");

        Text1.Callback = () => Check_Correct();

        dialogTexts.Add(Text1);


        DialogManager.Show(dialogTexts);
    }

    private void Check_Correct()
    {
        if(DialogManager.Result == "Restart")
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("Restarting Game"));

            DialogManager.Show(dialogTexts);

            SceneManager.LoadScene("Main");
        }
        else if (DialogManager.Result == "Home")
        {
            var dialogTexts = new List<DialogData>();

            SceneManager.LoadScene("TitleMenu");

            dialogTexts.Add(new DialogData("Going Home"));

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            Application.Quit();

            dialogTexts.Add(new DialogData("Closing Game"));

            DialogManager.Show(dialogTexts);
        }
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}