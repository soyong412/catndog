using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Abutton : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public void Update()
    {
     
    }

    public void ChangeGameScene()
    {
        Social.ReportProgress(GPGSIds.achievement, 100, (bool success) => { });
        SceneManager.LoadScene("game");
    }

    
}

