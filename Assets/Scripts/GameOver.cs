using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //public Particle_Effect effect;
    public Button Rst_btn;
    public Button Bck_btn;
    private void Awake()
    {
        this.gameObject.SetActive(true);
        Debug.Log("Gameover screen is displayed ");
        Rst_btn.onClick.AddListener(Reload);
        Bck_btn.onClick.AddListener(Back);
    }
    public void Reload()
    {
        Debug.Log("You clicked on restart and reloaded the scene");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }
    public void Back()
    {
        Debug.Log("You clicked on back and went to Lobby");
        SceneManager.LoadScene(0);
    }
}
