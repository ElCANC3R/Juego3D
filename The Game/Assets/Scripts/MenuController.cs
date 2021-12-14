using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene("Horror");
        Time.timeScale = 1;
    }

    public void Salir()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }

}