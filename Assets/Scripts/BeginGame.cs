using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{
    private InputMaster controls;

    private AudioSource audioSource;

    private void Awake()
    {
        controls = new InputMaster();
        controls.UI.StartGame.performed += _ => StartGame();
        controls.UI.QuitGame.performed += _ => QuitGame();

        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        controls.UI.StartGame.Enable();
        controls.UI.QuitGame.Enable();
    }

    private void OnDisable()
    {
        controls.UI.StartGame.Disable();
        controls.UI.QuitGame.Disable();
    }

    public void StartGame()
    {
        audioSource.Play();
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
