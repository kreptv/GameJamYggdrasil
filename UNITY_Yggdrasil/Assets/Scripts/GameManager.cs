using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public PlayerMovementScript pms;
    public DropMagicScript dms;
    public GameUI gUI;

    public bool gameplayActive;

    public int health = 3;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void RestartLevel(){
      gameplayActive = true;
      health = 3;
      score = 0;
    }

    public void LoadMenu(){
      SceneManager.LoadScene("MenuScene");
    }

    public void LoadLevel(){
      SceneManager.LoadScene("LevelScene");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SubtractLife(){
      health --;

      if (health == 2){
        gUI.Life1.SetBool("LifeLoss", true);
      } else if (health == 1){
        gUI.Life2.SetBool("LifeLoss", true);
      }  else if (health == 0){
        gUI.Life3.SetBool("LifeLoss", true);
        GameOver();
      }
    }

    void GameOver(){
      gameplayActive = false;
      gUI.GameOverGO.SetActive(false);
    }

    public void AddPoints(){
      score += 100;
      gUI.UpdateScore();
    }



}
