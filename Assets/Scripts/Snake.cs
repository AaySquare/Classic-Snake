using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour
{
    [SerializeField] private GameObject tail;
    [SerializeField] private GameObject scoreManager;

    // Movement
    private Vector2 direction;
    private readonly float speed = 0.2f;
    private readonly List<Transform> tails = new List<Transform>();

    // Input
    private InputMaster controls;

    // Sound
    public AudioClip appleCrunchSound;
    public AudioClip wallBumpSound;
    private AudioSource audioSource;

    //Getters and Setters
    public bool IsGameover { get; set; } = false;
    public bool HasEaten { get; set; } = false;

    private void Awake()
    {
        controls = new InputMaster();
        // Split up into 4 movements to ensure no diagonal movements
        controls.Player.MovementUp.performed += ctx => HandleInputUp();
        controls.Player.MovementDown.performed += ctx => HandleInputDown();
        controls.Player.MovementLeft.performed += ctx => HandleInputLeft();
        controls.Player.MovementRight.performed += ctx => HandleInputRight();

        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        //Call to Movement every specified seconds instead of every frame (Otherwise it's too fast!)
        InvokeRepeating("Movement", 1.0f, speed);
    }

    #region Old Input System
    /*void HandleInput()
    {
        //Player controls
        /*if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if(direction != Vector2.left || tails.Count == 0)
            {
                direction = Vector2.right;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (direction != Vector2.right || tails.Count == 0)
            {
                direction = Vector2.left;
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (direction != Vector2.down || tails.Count == 0)
            {
                direction = Vector2.up;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (direction != Vector2.up || tails.Count == 0)
            {
                direction = Vector2.down;
            }
        }
        
    }*/
    #endregion

    private void HandleInputUp()
    {
        if (direction != Vector2.down || tails.Count == 0)
        {
            direction = Vector2.up;
        }
    }

    private void HandleInputDown()
    {
        if (direction != Vector2.up || tails.Count == 0)
        {
            direction = Vector2.down;
        }
    }

    private void HandleInputLeft()
    {
        if (direction != Vector2.right || tails.Count == 0)
        {
            direction = Vector2.left;
        }
    }

    private void HandleInputRight()
    {
        if (direction != Vector2.left || tails.Count == 0)
        {
            direction = Vector2.right;
        }
    }

    private void Movement()
    {
        //If it is not game over, keep moving the snake head and tails
        if (!IsGameover)
        {
            //Get snake head's position before moving it
            Vector2 previousHeadPosition = transform.position;

            //To move game object 1 unit at a time
            transform.Translate(direction);

            //If food is eaten, spawn a new tail at the last location of the snake head
            if (HasEaten)
            {
                GameObject newTail = Instantiate(tail, previousHeadPosition, Quaternion.identity);
                tails.Insert(0, newTail.transform);
                HasEaten = false;
            }

            //Check if there is any tail
            if (tails.Count > 0)
            {
                //Set the position of the last tail to be previous position of snake head
                tails.Last().position = previousHeadPosition;

                //Set the last tail to be at the front
                tails.Insert(0, tails.Last());

                //Remove the last tail
                tails.RemoveAt(tails.Count - 1);
            }
        }
    }

    private void OnEnable()
    {
        controls.Player.MovementUp.Enable();
        controls.Player.MovementDown.Enable();
        controls.Player.MovementLeft.Enable();
        controls.Player.MovementRight.Enable();
    }

    private void OnDisable()
    {
        controls.Player.MovementUp.Disable();
        controls.Player.MovementDown.Disable();
        controls.Player.MovementLeft.Disable();
        controls.Player.MovementRight.Disable();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Border") || collision.gameObject.CompareTag("Tail"))
        {
            IsGameover = true;
            audioSource.PlayOneShot(wallBumpSound);
        }
        else if (collision.CompareTag("Food"))
        {
            HasEaten = true;
            audioSource.PlayOneShot(appleCrunchSound);
            scoreManager.GetComponent<Score>().AddScore();
            collision.gameObject.GetComponent<Food>().SpawnFood();
            collision.gameObject.SetActive(false);
        }
    }
}
