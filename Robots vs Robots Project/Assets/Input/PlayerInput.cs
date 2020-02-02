// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""MatchControls"",
            ""id"": ""32bd36b4-c595-464c-a860-7339a16b9773"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""d22a54be-06fd-4dd2-9a44-82dfafc94604"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""aa4b3d9a-3b51-4eaa-bf4f-77c80b5d9e50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""289eb560-e745-474d-8b6f-ddb950d7f265"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""70912227-5fb7-41f2-83c7-f74f43d6a0eb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""2ae8d9c2-0a1c-4eac-a134-8c06cec0cb1a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""638a5c81-d5ac-4461-b573-6091d20c2a73"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8bfbc79-fbed-4486-8c8a-09dedfed9601"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04e63cdc-1ab8-41db-81df-dadece910a3b"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce5c8064-03bc-40f2-94ed-b698900544fb"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40ab18dd-a8f1-4e3d-90c6-dc25923c3da1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""287a7ad6-562b-432b-924f-009f719b4877"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MatchControlsP2"",
            ""id"": ""f85ab931-9c2a-4385-ba72-224863c96459"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""513dcc71-ddb3-4b80-93f4-d1df81f7d031"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""84951828-3209-409d-b6ea-785ba6041ed2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""9379d76f-8e1c-489c-8e27-e8b5aeae27e8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""74179e60-d345-4238-9f5f-ad6f1cba7f7d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""2111e740-404b-4f23-91ab-c2be2ddcc3ea"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4c5b7e06-c4ea-4643-ae36-37417b99e1c5"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0c01643-4fb8-4244-a093-63185beb5776"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb79c5e4-eed7-4355-b99a-51ce4c70b44e"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c8f81b2-e573-4f86-b636-b2e18a25d437"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f292ec2b-2257-45e4-a310-1aacc8ec8fb7"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d52417b0-6a74-4b39-9ffb-f2b29a151fd0"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16539638-78ff-41d3-8ce0-ca49bc3ff640"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd4afeb9-1037-4003-ba5a-172bf625e55d"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adc8bae7-64bb-4ab3-93c3-7761a8b4d884"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlaceControls"",
            ""id"": ""c74bb175-9625-4b8b-a017-8beb28754ec8"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""485597c9-aacb-496f-be4b-f60068e62786"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""2dda3e49-8d62-4ad1-a6b8-eac5928e04bd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""872c01d6-7e01-49cb-bd6a-12d82f6a9105"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""56349d0b-01cc-489a-9f2e-9bfa28040c24"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c54895f3-94ba-470e-8acc-9d1229a24f04"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5840dacc-74fb-4529-8b2e-1b6ea14e5101"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""611420be-0f56-44f3-9795-288ef92bfd65"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlaceControlsP2"",
            ""id"": ""a4a6c826-8a5b-4a11-a876-6a8a5038c3d3"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""62d44ead-b63b-4600-a962-501f485837e9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""d0b0c87d-29a1-4f8f-b578-cd6754d816b4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""e1829687-0f60-4584-8ac6-0c1df4d1728a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a94d1227-08be-48d1-8d89-7d66dce83854"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77f5a2ad-8c6c-4cfa-96dc-48e14657dd6b"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0b4f2c2-418c-4eee-b939-68c60f47a040"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aefde57f-0048-41d0-b4ad-327597281729"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ea2c187-b5e5-4f87-bcdd-007903bc6680"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MatchControls
        m_MatchControls = asset.FindActionMap("MatchControls", throwIfNotFound: true);
        m_MatchControls_Select = m_MatchControls.FindAction("Select", throwIfNotFound: true);
        m_MatchControls_Up = m_MatchControls.FindAction("Up", throwIfNotFound: true);
        m_MatchControls_Down = m_MatchControls.FindAction("Down", throwIfNotFound: true);
        m_MatchControls_Left = m_MatchControls.FindAction("Left", throwIfNotFound: true);
        m_MatchControls_Right = m_MatchControls.FindAction("Right", throwIfNotFound: true);
        // MatchControlsP2
        m_MatchControlsP2 = asset.FindActionMap("MatchControlsP2", throwIfNotFound: true);
        m_MatchControlsP2_Select = m_MatchControlsP2.FindAction("Select", throwIfNotFound: true);
        m_MatchControlsP2_Up = m_MatchControlsP2.FindAction("Up", throwIfNotFound: true);
        m_MatchControlsP2_Down = m_MatchControlsP2.FindAction("Down", throwIfNotFound: true);
        m_MatchControlsP2_Left = m_MatchControlsP2.FindAction("Left", throwIfNotFound: true);
        m_MatchControlsP2_Right = m_MatchControlsP2.FindAction("Right", throwIfNotFound: true);
        // PlaceControls
        m_PlaceControls = asset.FindActionMap("PlaceControls", throwIfNotFound: true);
        m_PlaceControls_Up = m_PlaceControls.FindAction("Up", throwIfNotFound: true);
        m_PlaceControls_Down = m_PlaceControls.FindAction("Down", throwIfNotFound: true);
        m_PlaceControls_Confirm = m_PlaceControls.FindAction("Confirm", throwIfNotFound: true);
        // PlaceControlsP2
        m_PlaceControlsP2 = asset.FindActionMap("PlaceControlsP2", throwIfNotFound: true);
        m_PlaceControlsP2_Up = m_PlaceControlsP2.FindAction("Up", throwIfNotFound: true);
        m_PlaceControlsP2_Down = m_PlaceControlsP2.FindAction("Down", throwIfNotFound: true);
        m_PlaceControlsP2_Confirm = m_PlaceControlsP2.FindAction("Confirm", throwIfNotFound: true);
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

    // MatchControls
    private readonly InputActionMap m_MatchControls;
    private IMatchControlsActions m_MatchControlsActionsCallbackInterface;
    private readonly InputAction m_MatchControls_Select;
    private readonly InputAction m_MatchControls_Up;
    private readonly InputAction m_MatchControls_Down;
    private readonly InputAction m_MatchControls_Left;
    private readonly InputAction m_MatchControls_Right;
    public struct MatchControlsActions
    {
        private @PlayerInput m_Wrapper;
        public MatchControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_MatchControls_Select;
        public InputAction @Up => m_Wrapper.m_MatchControls_Up;
        public InputAction @Down => m_Wrapper.m_MatchControls_Down;
        public InputAction @Left => m_Wrapper.m_MatchControls_Left;
        public InputAction @Right => m_Wrapper.m_MatchControls_Right;
        public InputActionMap Get() { return m_Wrapper.m_MatchControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MatchControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMatchControlsActions instance)
        {
            if (m_Wrapper.m_MatchControlsActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnSelect;
                @Up.started -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_MatchControlsActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_MatchControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public MatchControlsActions @MatchControls => new MatchControlsActions(this);

    // MatchControlsP2
    private readonly InputActionMap m_MatchControlsP2;
    private IMatchControlsP2Actions m_MatchControlsP2ActionsCallbackInterface;
    private readonly InputAction m_MatchControlsP2_Select;
    private readonly InputAction m_MatchControlsP2_Up;
    private readonly InputAction m_MatchControlsP2_Down;
    private readonly InputAction m_MatchControlsP2_Left;
    private readonly InputAction m_MatchControlsP2_Right;
    public struct MatchControlsP2Actions
    {
        private @PlayerInput m_Wrapper;
        public MatchControlsP2Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_MatchControlsP2_Select;
        public InputAction @Up => m_Wrapper.m_MatchControlsP2_Up;
        public InputAction @Down => m_Wrapper.m_MatchControlsP2_Down;
        public InputAction @Left => m_Wrapper.m_MatchControlsP2_Left;
        public InputAction @Right => m_Wrapper.m_MatchControlsP2_Right;
        public InputActionMap Get() { return m_Wrapper.m_MatchControlsP2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MatchControlsP2Actions set) { return set.Get(); }
        public void SetCallbacks(IMatchControlsP2Actions instance)
        {
            if (m_Wrapper.m_MatchControlsP2ActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnSelect;
                @Up.started -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_MatchControlsP2ActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_MatchControlsP2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public MatchControlsP2Actions @MatchControlsP2 => new MatchControlsP2Actions(this);

    // PlaceControls
    private readonly InputActionMap m_PlaceControls;
    private IPlaceControlsActions m_PlaceControlsActionsCallbackInterface;
    private readonly InputAction m_PlaceControls_Up;
    private readonly InputAction m_PlaceControls_Down;
    private readonly InputAction m_PlaceControls_Confirm;
    public struct PlaceControlsActions
    {
        private @PlayerInput m_Wrapper;
        public PlaceControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_PlaceControls_Up;
        public InputAction @Down => m_Wrapper.m_PlaceControls_Down;
        public InputAction @Confirm => m_Wrapper.m_PlaceControls_Confirm;
        public InputActionMap Get() { return m_Wrapper.m_PlaceControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlaceControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlaceControlsActions instance)
        {
            if (m_Wrapper.m_PlaceControlsActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_PlaceControlsActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_PlaceControlsActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_PlaceControlsActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_PlaceControlsActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_PlaceControlsActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_PlaceControlsActionsCallbackInterface.OnDown;
                @Confirm.started -= m_Wrapper.m_PlaceControlsActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_PlaceControlsActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_PlaceControlsActionsCallbackInterface.OnConfirm;
            }
            m_Wrapper.m_PlaceControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
            }
        }
    }
    public PlaceControlsActions @PlaceControls => new PlaceControlsActions(this);

    // PlaceControlsP2
    private readonly InputActionMap m_PlaceControlsP2;
    private IPlaceControlsP2Actions m_PlaceControlsP2ActionsCallbackInterface;
    private readonly InputAction m_PlaceControlsP2_Up;
    private readonly InputAction m_PlaceControlsP2_Down;
    private readonly InputAction m_PlaceControlsP2_Confirm;
    public struct PlaceControlsP2Actions
    {
        private @PlayerInput m_Wrapper;
        public PlaceControlsP2Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_PlaceControlsP2_Up;
        public InputAction @Down => m_Wrapper.m_PlaceControlsP2_Down;
        public InputAction @Confirm => m_Wrapper.m_PlaceControlsP2_Confirm;
        public InputActionMap Get() { return m_Wrapper.m_PlaceControlsP2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlaceControlsP2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlaceControlsP2Actions instance)
        {
            if (m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface.OnDown;
                @Confirm.started -= m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface.OnConfirm;
            }
            m_Wrapper.m_PlaceControlsP2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
            }
        }
    }
    public PlaceControlsP2Actions @PlaceControlsP2 => new PlaceControlsP2Actions(this);
    public interface IMatchControlsActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
    public interface IMatchControlsP2Actions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
    public interface IPlaceControlsActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
    }
    public interface IPlaceControlsP2Actions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
    }
}
