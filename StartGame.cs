using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Animator transition;
    public bool movecarenable = false;
    public GameObject Moveobject;
    public GameObject HowToPlay;
    public GameObject Credits;
    public void Update()
    {
       if(movecarenable == true)
        {
            Moveobject.transform.position += transform.forward * Time.deltaTime;
            Invoke("PlayGame", 15f);
        }
    }

    public void PlayGame()
    {
        movecarenable = true;

        LoadGame();

       
        


    }

    public void MarketPlace()
    {

        SceneManager.LoadScene("Store");
    }

    private void LoadGame()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex +1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);
    }
    public void HowToPlay1()
    {
        HowToPlay.SetActive(true);
        
    }
    public void Back()
    {
        HowToPlay.SetActive(false);
        Credits.SetActive(false);

    }

    public void Credits1()
    {
        Credits.SetActive(true);
    }
}
