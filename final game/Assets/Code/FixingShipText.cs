using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class FixingShipText : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Hello Commander good job taking care of the aliens", "Shipmate"));
        dialogTexts.Add(new DialogData("We have taken quite a bit of damage I think it time repair the ship", "Shipmate", () => Show_Example(0)));
        dialogTexts.Add(new DialogData("This is the control panel.", "Shipmate", () => Show_Example(1)));
        dialogTexts.Add(new DialogData("By zooming on the screen once we finish of each alien wave we get access to the ship parts", "Shipmate", () => Show_Example(2)));
        dialogTexts.Add(new DialogData("This is the engine", "Shipmate", () => Show_Example(3)));
        dialogTexts.Add(new DialogData("These are the two ship thrusters each of them can be fixed independently", "Shipmate", () => Show_Example(4)));
        dialogTexts.Add(new DialogData("These are the two ship blasters each of them can be fixed independently", "Shipmate", () => Show_Example(5)));
        
        var Text1 = new DialogData("Choose wisely Commander", "Shipmate");

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

            /*dialogTexts.Add(new DialogData("Contining Game"));*/

            DialogManager.Show(dialogTexts);

            SceneManager.LoadScene("ControlPanel");
        }
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}