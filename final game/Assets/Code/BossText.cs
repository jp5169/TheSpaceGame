using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class BossText : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("The ship is picking something up on the radar Commander.", "Shipmate"));

        dialogTexts.Add(new DialogData("Something big and nasty is coming our way.", "Shipmate"));

        var Text1 = new DialogData("We are going to need all the repairs we can do. ", "Shipmate");

        Text1.SelectList.Add("Continue", "Continue");

        Text1.Callback = () => Check_Correct();

        dialogTexts.Add(Text1);

        DialogManager.Show(dialogTexts);
    }

    private void Check_Correct()
    {
        if(DialogManager.Result == "Continue")
        {
            var dialogTexts = new List<DialogData>();

            /*dialogTexts.Add(new DialogData("Restarting Game"));*/

            DialogManager.Show(dialogTexts);

            SceneManager.LoadScene("Main");
        }
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}