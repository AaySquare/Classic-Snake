using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayUI : MonoBehaviour
{
    [SerializeField] private GameObject controlsUI;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject player;

    private InputMaster controls;

    private AudioSource audioSource;

    private void Awake()
    {
        controls = new InputMaster();
        controls.UI.Controls.performed += _ => DisableControlsUI();
        controls.UI.QuitGame.performed += _ => QuitGame();

        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {  
        DisplayGameOverUI();
    }

    private void DisableControlsUI()
    {
        controlsUI.SetActive(false);
    }

    //Display Gameover canvas if it is Gameover
    private void DisplayGameOverUI()
    {
        if (player.GetComponent<Snake>().IsGameover)
        {
            gameOverUI.SetActive(true);
        }
    }

    private void OnEnable()
    {
        controls.UI.Controls.Enable();
        controls.UI.QuitGame.Enable();
    }

    private void OnDisable()
    {
        controls.UI.Controls.Disable();
        controls.UI.QuitGame.Disable();
    }

    public void BeginMenu()
    {
        audioSource.Play();
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
