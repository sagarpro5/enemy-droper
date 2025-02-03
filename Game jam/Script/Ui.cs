using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour
{
    public GameObject spawner;
    public GameObject mainmenu;
    public GameObject gameover;
    public GameObject player;
    public Transform o;



    public void closer() 
    {
        mainmenu.SetActive(false);
        spawner.SetActive(true);
    }

    public void restart()
    {
        gameover.SetActive(false);
        SceneManager.LoadScene(0);
        spawner.SetActive(false);
    }



}
