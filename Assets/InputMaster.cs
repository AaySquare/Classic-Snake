// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""961c6e6f-fcd1-46a1-814f-7ce8ee4309ce"",
            ""actions"": [
                {
                    ""name"": ""MovementUp"",
                    ""type"": ""Button"",
                    ""id"": ""2c16687d-c005-441b-b9d4-c91941edcf38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementDown"",
                    ""type"": ""Button"",
                    ""id"": ""e5c9ddb9-7943-41c2-b6d7-99cb8757de42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d1f4cb14-5f2e-4866-a53c-2c2f4871c46f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementRight"",
                    ""type"": ""Button"",
                    ""id"": ""0d06db99-0fc2-4558-8eb5-2ff21ca25002"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8ad07832-8ebc-4173-99fb-c833077772a3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MovementUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f148a341-75db-4ca6-80d4-58bea53b6f6d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MovementUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4570770-3bc6-4023-9b16-956f44f9f6a7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MovementDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3a91685-6d4c-4657-8476-e2845986c0a9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MovementDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c494d69-4043-4d1f-a6f1-b492f54adb70"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MovementLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19672397-7b2f-42c5-b571-9c552093460c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MovementLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5b8bff5-2985-47ab-9ad9-30b4c5c986b8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MovementRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ee27fc7-6fd8-48db-8785-18d1dd31ef2f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MovementRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""e9df1202-6739-4bc5-b130-12cd9aae7de1"",
            ""actions"": [
                {
                    ""name"": ""Controls"",
                    ""type"": ""Button"",
                    ""id"": ""918de640-54e7-4b7b-90ba-627c2c4ee5ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartGame"",
                    ""type"": ""Button"",
                    ""id"": ""eb3afb90-ef4f-4fff-9d7b-28bc00ca9934"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""QuitGame"",
                    ""type"": ""Button"",
                    ""id"": ""3487cb4f-753d-4f4b-b215-7a31d2963c79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dfa85aac-7c06-449e-b726-13d3515d7125"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Controls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00e48766-723a-425c-9215-d7d4558a8b05"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdc457b1-6014-4e09-ad44-0ece5c78e8de"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""QuitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MovementUp = m_Player.FindAction("MovementUp", throwIfNotFound: true);
        m_Player_MovementDown = m_Player.FindAction("MovementDown", throwIfNotFound: true);
        m_Player_MovementLeft = m_Player.FindAction("MovementLeft", throwIfNotFound: true);
        m_Player_MovementRight = m_Player.FindAction("MovementRight", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Controls = m_UI.FindAction("Controls", throwIfNotFound: true);
        m_UI_StartGame = m_UI.FindAction("StartGame", throwIfNotFound: true);
        m_UI_QuitGame = m_UI.FindAction("QuitGame", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MovementUp;
    private readonly InputAction m_Player_MovementDown;
    private readonly InputAction m_Player_MovementLeft;
    private readonly InputAction m_Player_MovementRight;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementUp => m_Wrapper.m_Player_MovementUp;
        public InputAction @MovementDown => m_Wrapper.m_Player_MovementDown;
        public InputAction @MovementLeft => m_Wrapper.m_Player_MovementLeft;
        public InputAction @MovementRight => m_Wrapper.m_Player_MovementRight;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MovementUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementUp;
                @MovementUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementUp;
                @MovementUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementUp;
                @MovementDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementDown;
                @MovementDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementDown;
                @MovementDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementDown;
                @MovementLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementLeft;
                @MovementLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementLeft;
                @MovementLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementLeft;
                @MovementRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementRight;
                @MovementRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementRight;
                @MovementRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovementRight;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementUp.started += instance.OnMovementUp;
                @MovementUp.performed += instance.OnMovementUp;
                @MovementUp.canceled += instance.OnMovementUp;
                @MovementDown.started += instance.OnMovementDown;
                @MovementDown.performed += instance.OnMovementDown;
                @MovementDown.canceled += instance.OnMovementDown;
                @MovementLeft.started += instance.OnMovementLeft;
                @MovementLeft.performed += instance.OnMovementLeft;
                @MovementLeft.canceled += instance.OnMovementLeft;
                @MovementRight.started += instance.OnMovementRight;
                @MovementRight.performed += instance.OnMovementRight;
                @MovementRight.canceled += instance.OnMovementRight;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Controls;
    private readonly InputAction m_UI_StartGame;
    private readonly InputAction m_UI_QuitGame;
    public struct UIActions
    {
        private @InputMaster m_Wrapper;
        public UIActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Controls => m_Wrapper.m_UI_Controls;
        public InputAction @StartGame => m_Wrapper.m_UI_StartGame;
        public InputAction @QuitGame => m_Wrapper.m_UI_QuitGame;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Controls.started -= m_Wrapper.m_UIActionsCallbackInterface.OnControls;
                @Controls.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnControls;
                @Controls.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnControls;
                @StartGame.started -= m_Wrapper.m_UIActionsCallbackInterface.OnStartGame;
                @StartGame.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnStartGame;
                @StartGame.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnStartGame;
                @QuitGame.started -= m_Wrapper.m_UIActionsCallbackInterface.OnQuitGame;
                @QuitGame.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnQuitGame;
                @QuitGame.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnQuitGame;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Controls.started += instance.OnControls;
                @Controls.performed += instance.OnControls;
                @Controls.canceled += instance.OnControls;
                @StartGame.started += instance.OnStartGame;
                @StartGame.performed += instance.OnStartGame;
                @StartGame.canceled += instance.OnStartGame;
                @QuitGame.started += instance.OnQuitGame;
                @QuitGame.performed += instance.OnQuitGame;
                @QuitGame.canceled += instance.OnQuitGame;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovementUp(InputAction.CallbackContext context);
        void OnMovementDown(InputAction.CallbackContext context);
        void OnMovementLeft(InputAction.CallbackContext context);
        void OnMovementRight(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnControls(InputAction.CallbackContext context);
        void OnStartGame(InputAction.CallbackContext context);
        void OnQuitGame(InputAction.CallbackContext context);
    }
}
