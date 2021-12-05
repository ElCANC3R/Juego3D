using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void Reiniciar()
    {

        SceneManager.LoadScene("DemoScene");
        Time.timeScale = 1;
    }
    public void Salir()
    {
        Application.Quit();
    }
}