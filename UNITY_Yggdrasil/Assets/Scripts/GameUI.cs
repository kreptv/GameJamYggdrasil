using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{

    public GameManager gm;
    public GameObject ScoreGO;
    public Animator Life1;
    public Animator Life2;
    public Animator Life3;

    public GameObject GameOverGO;

    public Button Retry;
    public Button Menu;
    public Button Starte;

    // Start is called before the first frame update
    void Start()
    {
      if (Retry){
        Button retrybtn = Retry.GetComponent<Button>();
        retrybtn.onClick.AddListener(retryTask);
      }
      if (Menu){
        Button menubtn = Menu.GetComponent<Button>();
        menubtn.onClick.AddListener(menuTask);
      }
      if (Starte){
        Button startbtn = Starte.GetComponent<Button>();
        startbtn.onClick.AddListener(startTask);
      }
      if (ScoreGO){
        ScoreGO.GetComponent<TMP_Text>().text = "0";
      }
    }

    void retryTask(){
        gm.RestartLevel();
        GameOverGO.SetActive(false);
    	}

    void menuTask(){
        gm.LoadMenu();
	    }

      void startTask(){
        gm.LoadLevel();
        gm.RestartLevel();
      }


    public void UpdateScore(){
      ScoreGO.GetComponent<TMP_Text>().text = gm.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
