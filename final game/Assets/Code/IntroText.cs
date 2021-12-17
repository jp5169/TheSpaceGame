using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class IntroText : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Welcome commander its great to have you back from your deep sleep.", "Shipmate"));

        dialogTexts.Add(new DialogData("The alien race has reached earth and they are in full attack, if you are not awake you will lose this war.", "Deadmate"));
        
        dialogTexts.Add(new DialogData("Use the joystick to divert the ship away from the incoming fire", "Deadmate"));

        dialogTexts.Add(new DialogData("You need to use the fire button to shoot everything that is coming towards you.", "Deadmate"));

        var Text1 = new DialogData("Those nasty creatures will try to attack every single spaceship part to take us down.", "Deadmate");

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