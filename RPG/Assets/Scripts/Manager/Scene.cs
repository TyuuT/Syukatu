using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{

    void Awake()
    {
        Screen.SetResolution(1024, 768, false, 60);
    }

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void Scenario1()
    {
        SceneManager.LoadScene("Scenario1");
    }

    public void Scenario2()
    {
        SceneManager.LoadScene("Scenario2");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void BattleScene()
    {
        SceneManager.LoadScene("BattleScene");
    }

    public void BattleScene2()
    {
        SceneManager.LoadScene("BattleScene2");
    }

    public void Clear()
    {
        SceneManager.LoadScene("Clear");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void Title()
    {
        SceneManager.LoadScene("Title");
    }

}
