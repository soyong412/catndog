using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GooglePlayGames;
using UnityEngine.UI;

public class People : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Social.ReportProgress(GPGSIds.achievement__, 100, (bool success) => { });
    }

    public void ChangeGameScene()
    {
        SceneManager.LoadScene("people");
    }
}
