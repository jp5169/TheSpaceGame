using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Settings : MonoBehaviour
{
    public Sprite card;
    public List<Button> pieces = new List<Button>();

    public Sprite[] faces;
    public List<Sprite> gameFaces = new List<Sprite>();
    public List<Sprite> finalGameFaces = new List<Sprite>();
    public List<int> nums = new List<int>();

    float time = 20f;
    public Text timeLeft;


    int wincount = 0;

    bool guessed = true;

    int random;
    int count = 0;

    int index;

    void Start()
    {
        createPieces();
        foreach (Button piece in pieces)
        {
            piece.onClick.AddListener(() => pick());
        }
        pickFaces();
    }

    void Update()
    {
        if (time < 0)
        {
            
            SceneManager.LoadScene("Main2");

        }
        if (time > 0)
        {
            time -= Time.deltaTime;
            timeLeft.text = ((int)time).ToString();
        }
    }

    void createPieces()
    {
        
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Piece");
       
        for (int i = 0; i < objects.Length; i++)
        {
            pieces.Add(objects[i].GetComponent<Button>());
            pieces[i].image.sprite = card;   
        }
    }

    void pickFaces()
    {
        while (count < 4){
            random = Random.Range(0, 8);
           
            if (!nums.Contains(random))
            {
                nums.Add(random);
                gameFaces.Add(faces[random]);
                count += 1;
            }
        }
        
        while (gameFaces.Count != 0)
        {
            random = Random.Range(0, gameFaces.Count);
            if (finalGameFaces.Contains(gameFaces[random]))
            {
                finalGameFaces.Add(gameFaces[random]);
                gameFaces.Remove(gameFaces[random]);
            }
            else
            {
                finalGameFaces.Add(gameFaces[random]);
            }
        }
        nums.Clear();
    }


    void pick()
    {
        index = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        if (!nums.Contains(index)){

            nums.Add(index);
            guessed = !guessed;

            pieces[index].image.sprite = finalGameFaces[index]; //changes sprite

            if (guessed)
            {
                StartCoroutine(CheckWin());
            }
        }
    }

    public IEnumerator CheckWin()
    {
        yield return new WaitForSeconds(.3f);
        if (finalGameFaces[nums[0]].name == finalGameFaces[nums[1]].name)
        {
            pieces[nums[0]].interactable = false;
            pieces[nums[1]].interactable = false;
            wincount += 1;
            if (wincount == 4)
            {
                SceneManager.LoadScene("Main2");
                PublicVars.engineHealth = 100f;
                PublicVars.blasterLowHealth = 100f;
                PublicVars.blasterUpHealth = 100f;
                PublicVars.boosterUpHealth = 100f;
                PublicVars.boosterLowHealth = 100f;
            }
            
        }
        else
        {
            pieces[nums[0]].image.sprite = card;
            pieces[nums[1]].image.sprite = card;
        }

        nums.Clear();
    }
}
