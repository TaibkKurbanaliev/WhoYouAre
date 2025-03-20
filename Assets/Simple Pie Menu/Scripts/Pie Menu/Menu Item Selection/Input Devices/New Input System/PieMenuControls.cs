//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.13.1
//     from Assets/Simple Pie Menu/Scripts/Pie Menu/Menu Item Selection/Input Devices/New Input System/PieMenuControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace SimplePieMenu
{
    /// <summary>
    /// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Simple Pie Menu/Scripts/Pie Menu/Menu Item Selection/Input Devices/New Input System/PieMenuControls.inputactions".
    /// </summary>
    /// <remarks>
    /// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
    /// </remarks>
    /// <example>
    /// <code>
    /// using namespace UnityEngine;
    /// using UnityEngine.InputSystem;
    ///
    /// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
    /// public class Example : MonoBehaviour, MyActions.IPlayerActions
    /// {
    ///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
    ///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
    ///
    ///     void Awake()
    ///     {
    ///         m_Actions = new MyActions_Actions();              // Create asset object.
    ///         m_Player = m_Actions.Player;                      // Extract action map object.
    ///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
    ///     }
    ///
    ///     void OnDestroy()
    ///     {
    ///         m_Actions.Dispose();                              // Destroy asset object.
    ///     }
    ///
    ///     void OnEnable()
    ///     {
    ///         m_Player.Enable();                                // Enable all actions within map.
    ///     }
    ///
    ///     void OnDisable()
    ///     {
    ///         m_Player.Disable();                               // Disable all actions within map.
    ///     }
    ///
    ///     #region Interface implementation of MyActions.IPlayerActions
    ///
    ///     // Invoked when "Move" action is either started, performed or canceled.
    ///     public void OnMove(InputAction.CallbackContext context)
    ///     {
    ///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
    ///     }
    ///
    ///     // Invoked when "Attack" action is either started, performed or canceled.
    ///     public void OnAttack(InputAction.CallbackContext context)
    ///     {
    ///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
    ///     }
    ///
    ///     #endregion
    /// }
    /// </code>
    /// </example>
    public partial class @PieMenuControls: IInputActionCollection2, IDisposable
    {
        /// <summary>
        /// Provides access to the underlying asset instance.
        /// </summary>
        public InputActionAsset asset { get; }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public @PieMenuControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PieMenuControls"",
    ""maps"": [
        {
            ""name"": ""MouseAndKeyboard"",
            ""id"": ""57d71994-ef4d-44b0-b848-eb4cd65d2dd8"",
            ""actions"": [
                {
                    ""name"": ""Selection"",
                    ""type"": ""Button"",
                    ""id"": ""758310ad-2d2f-441a-a069-a787082fcc8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""c034a993-d15b-4eba-bc13-ad64b802bef5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pointer Position"",
                    ""type"": ""Value"",
                    ""id"": ""73cdcf3e-1545-47e1-b6c5-d6996058bbf8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5b476b9c-c389-4082-a44e-8f6ee70545f8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74c6b187-2f2f-4a39-8f67-54d0f4c75215"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pointer Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdabd5a9-c7e1-4958-868b-bf7b7407f669"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // MouseAndKeyboard
            m_MouseAndKeyboard = asset.FindActionMap("MouseAndKeyboard", throwIfNotFound: true);
            m_MouseAndKeyboard_Selection = m_MouseAndKeyboard.FindAction("Selection", throwIfNotFound: true);
            m_MouseAndKeyboard_Close = m_MouseAndKeyboard.FindAction("Close", throwIfNotFound: true);
            m_MouseAndKeyboard_PointerPosition = m_MouseAndKeyboard.FindAction("Pointer Position", throwIfNotFound: true);
        }

        ~@PieMenuControls()
        {
            UnityEngine.Debug.Assert(!m_MouseAndKeyboard.enabled, "This will cause a leak and performance issues, PieMenuControls.MouseAndKeyboard.Disable() has not been called.");
        }

        /// <summary>
        /// Destroys this asset and all associated <see cref="InputAction"/> instances.
        /// </summary>
        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
        public void Enable()
        {
            asset.Enable();
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
        public void Disable()
        {
            asset.Disable();
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
        public IEnumerable<InputBinding> bindings => asset.bindings;

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // MouseAndKeyboard
        private readonly InputActionMap m_MouseAndKeyboard;
        private List<IMouseAndKeyboardActions> m_MouseAndKeyboardActionsCallbackInterfaces = new List<IMouseAndKeyboardActions>();
        private readonly InputAction m_MouseAndKeyboard_Selection;
        private readonly InputAction m_MouseAndKeyboard_Close;
        private readonly InputAction m_MouseAndKeyboard_PointerPosition;
        /// <summary>
        /// Provides access to input actions defined in input action map "MouseAndKeyboard".
        /// </summary>
        public struct MouseAndKeyboardActions
        {
            private @PieMenuControls m_Wrapper;

            /// <summary>
            /// Construct a new instance of the input action map wrapper class.
            /// </summary>
            public MouseAndKeyboardActions(@PieMenuControls wrapper) { m_Wrapper = wrapper; }
            /// <summary>
            /// Provides access to the underlying input action "MouseAndKeyboard/Selection".
            /// </summary>
            public InputAction @Selection => m_Wrapper.m_MouseAndKeyboard_Selection;
            /// <summary>
            /// Provides access to the underlying input action "MouseAndKeyboard/Close".
            /// </summary>
            public InputAction @Close => m_Wrapper.m_MouseAndKeyboard_Close;
            /// <summary>
            /// Provides access to the underlying input action "MouseAndKeyboard/PointerPosition".
            /// </summary>
            public InputAction @PointerPosition => m_Wrapper.m_MouseAndKeyboard_PointerPosition;
            /// <summary>
            /// Provides access to the underlying input action map instance.
            /// </summary>
            public InputActionMap Get() { return m_Wrapper.m_MouseAndKeyboard; }
            /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
            public void Enable() { Get().Enable(); }
            /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
            public void Disable() { Get().Disable(); }
            /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
            public bool enabled => Get().enabled;
            /// <summary>
            /// Implicitly converts an <see ref="MouseAndKeyboardActions" /> to an <see ref="InputActionMap" /> instance.
            /// </summary>
            public static implicit operator InputActionMap(MouseAndKeyboardActions set) { return set.Get(); }
            /// <summary>
            /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
            /// </summary>
            /// <param name="instance">Callback instance.</param>
            /// <remarks>
            /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
            /// </remarks>
            /// <seealso cref="MouseAndKeyboardActions" />
            public void AddCallbacks(IMouseAndKeyboardActions instance)
            {
                if (instance == null || m_Wrapper.m_MouseAndKeyboardActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_MouseAndKeyboardActionsCallbackInterfaces.Add(instance);
                @Selection.started += instance.OnSelection;
                @Selection.performed += instance.OnSelection;
                @Selection.canceled += instance.OnSelection;
                @Close.started += instance.OnClose;
                @Close.performed += instance.OnClose;
                @Close.canceled += instance.OnClose;
                @PointerPosition.started += instance.OnPointerPosition;
                @PointerPosition.performed += instance.OnPointerPosition;
                @PointerPosition.canceled += instance.OnPointerPosition;
            }

            /// <summary>
            /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
            /// </summary>
            /// <remarks>
            /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
            /// </remarks>
            /// <seealso cref="MouseAndKeyboardActions" />
            private void UnregisterCallbacks(IMouseAndKeyboardActions instance)
            {
                @Selection.started -= instance.OnSelection;
                @Selection.performed -= instance.OnSelection;
                @Selection.canceled -= instance.OnSelection;
                @Close.started -= instance.OnClose;
                @Close.performed -= instance.OnClose;
                @Close.canceled -= instance.OnClose;
                @PointerPosition.started -= instance.OnPointerPosition;
                @PointerPosition.performed -= instance.OnPointerPosition;
                @PointerPosition.canceled -= instance.OnPointerPosition;
            }

            /// <summary>
            /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="MouseAndKeyboardActions.UnregisterCallbacks(IMouseAndKeyboardActions)" />.
            /// </summary>
            /// <seealso cref="MouseAndKeyboardActions.UnregisterCallbacks(IMouseAndKeyboardActions)" />
            public void RemoveCallbacks(IMouseAndKeyboardActions instance)
            {
                if (m_Wrapper.m_MouseAndKeyboardActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            /// <summary>
            /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
            /// </summary>
            /// <remarks>
            /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
            /// </remarks>
            /// <seealso cref="MouseAndKeyboardActions.AddCallbacks(IMouseAndKeyboardActions)" />
            /// <seealso cref="MouseAndKeyboardActions.RemoveCallbacks(IMouseAndKeyboardActions)" />
            /// <seealso cref="MouseAndKeyboardActions.UnregisterCallbacks(IMouseAndKeyboardActions)" />
            public void SetCallbacks(IMouseAndKeyboardActions instance)
            {
                foreach (var item in m_Wrapper.m_MouseAndKeyboardActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_MouseAndKeyboardActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        /// <summary>
        /// Provides a new <see cref="MouseAndKeyboardActions" /> instance referencing this action map.
        /// </summary>
        public MouseAndKeyboardActions @MouseAndKeyboard => new MouseAndKeyboardActions(this);
        /// <summary>
        /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "MouseAndKeyboard" which allows adding and removing callbacks.
        /// </summary>
        /// <seealso cref="MouseAndKeyboardActions.AddCallbacks(IMouseAndKeyboardActions)" />
        /// <seealso cref="MouseAndKeyboardActions.RemoveCallbacks(IMouseAndKeyboardActions)" />
        public interface IMouseAndKeyboardActions
        {
            /// <summary>
            /// Method invoked when associated input action "Selection" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
            /// </summary>
            /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
            void OnSelection(InputAction.CallbackContext context);
            /// <summary>
            /// Method invoked when associated input action "Close" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
            /// </summary>
            /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
            void OnClose(InputAction.CallbackContext context);
            /// <summary>
            /// Method invoked when associated input action "Pointer Position" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
            /// </summary>
            /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
            /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
            void OnPointerPosition(InputAction.CallbackContext context);
        }
    }
}
