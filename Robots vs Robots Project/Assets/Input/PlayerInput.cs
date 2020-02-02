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
        // PlaceControls
        m_PlaceControls = asset.FindActionMap("PlaceControls", throwIfNotFound: true);
        m_PlaceControls_Up = m_PlaceControls.FindAction("Up", throwIfNotFound: true);
        m_PlaceControls_Down = m_PlaceControls.FindAction("Down", throwIfNotFound: true);
        m_PlaceControls_Confirm = m_PlaceControls.FindAction("Confirm", throwIfNotFound: true);
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
    public interface IMatchControlsActions
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
}
