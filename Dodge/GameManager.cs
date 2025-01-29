using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverText;
    public Text TimeText;
    public Text BestRecordText;

    private float SurviveTime;
    private bool GameOver;
    // Start is called before the first frame update
    void Start()
    {
        SurviveTime = 0;
        GameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameOver != true){
            SurviveTime += Time.deltaTime;

            TimeText.text = "Time : " + (int)SurviveTime;
        }

        else{
            if(Input.GetKeyDown(KeyCode.R)){  
            SceneManager.LoadScene("SampleScene");
        }
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }

    public void EndGame(){

        GameOver = true;

        GameOverText.SetActive(true);

        float BestTime = PlayerPrefs.GetFloat("BestTime");

        if(SurviveTime >= BestTime){

            BestTime =(int)SurviveTime;
            PlayerPrefs.SetFloat("BestTime", BestTime);
        }

        BestRecordText.text = "Best Score :" + BestTime;

    }
}
