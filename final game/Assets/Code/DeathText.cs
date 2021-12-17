using System.ComponentModel.Design;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class DeathText : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Commander I have failed you.", "Shipmate"));

        dialogTexts.Add(new DialogData("Commander I'm dying.", "Deadmate"));
        
        dialogTexts.Add(new DialogData("Loser", "Alien"));

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
            PublicVars.engineHealth = 100f;
            PublicVars.blasterLowHealth = 100f;
            PublicVars.blasterUpHealth = 100f;
            PublicVars.boosterUpHealth = 100f;
            PublicVars.boosterLowHealth = 100f;
            
            SceneManager.LoadScene("Main");
        }
        else if (DialogManager.Result == "Home")
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("Going Home"));
            SceneManager.LoadScene("TitleMenu");

            DialogManager.Show(dialogTexts);
        }
        else
        {
            var dialogTexts = new List<DialogData>();

            dialogTexts.Add(new DialogData("Closing Game"));

            Application.Quit();

            DialogManager.Show(dialogTexts);
        }
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}