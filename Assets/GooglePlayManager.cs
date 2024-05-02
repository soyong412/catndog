using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.UI;

public class GooglePlayManager : MonoBehaviour
{
    public Text LogText;

   // ScoreManager scom;
    


    void Start()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
        LogIn();
       // scom = GameObject.Find("BestScore_").GetComponent<ScoreManager>();

    }


    public void LogIn()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            if (success) LogText.text = Social.localUser.id + " \n " + Social.localUser.userName;



            else LogText.text = "구글 로그인 실패";
        });
    }


    public void LogOut()
    {
        ((PlayGamesPlatform)Social.Active).SignOut();
        LogText.text = "구글 로그아웃";
    }

    void Update()
    {
       // ReportScore();
       // Debug.Log(scom.SaveScore);
    }
    public void OnShowAchievement()
    {
       
        Social.ShowAchievementsUI();
    }


    public void ShowLeaderboardUI() => Social.ShowLeaderboardUI();
}

