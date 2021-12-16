﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GenshinScanner.Input
{
    public sealed class KeyboardHook : IDisposable
    {
        // Registers a hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        // Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        
        /// <summary>
        /// Represents the window that is used internally to get the messages.
        /// </summary>
        private class Window : NativeWindow, IDisposable
        {
            private static int WM_HOTKEY = 0x0312;

            public Window()
            {
                // create the handle for the window.
                this.CreateHandle(new CreateParams());
            }

            /// <summary>
            /// Overridden to get the notifications.
            /// </summary>
            /// <param name="m"></param>
            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                // check if we got a hot key pressed.
                if (m.Msg != WM_HOTKEY) return;
                // get the keys.
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
#pragma warning disable CS0436 // Type conflicts with imported type
#pragma warning disable CS0436 // Type conflicts with imported type
                ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 0xFFFF);
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning restore CS0436 // Type conflicts with imported type

                // invoke the event to notify the parent.
                if (KeyPressed != null)
#pragma warning disable CS0436 // Type conflicts with imported type
                    KeyPressed(this, new KeyPressedEventArgs(modifier, key));
#pragma warning restore CS0436 // Type conflicts with imported type
            }

#pragma warning disable CS0436 // Type conflicts with imported type
            public event EventHandler<KeyPressedEventArgs> KeyPressed;
#pragma warning restore CS0436 // Type conflicts with imported type

            #region IDisposable Members

            public void Dispose()
            {
                this.DestroyHandle();
            }

            #endregion
        }

        private readonly Window _window = new Window();
        private int _currentId;

        public KeyboardHook()
        {
            // register the event of the inner native window.
#pragma warning disable CS0436 // Type conflicts with imported type
            _window.KeyPressed += delegate (object sender, KeyPressedEventArgs args)
#pragma warning restore CS0436 // Type conflicts with imported type
            {
                KeyPressed?.Invoke(this, args);
            };
        }

        /// <summary>
        /// Registers a hot key in the system.
        /// </summary>
        /// <param name="modifier">The modifiers that are associated with the hot key.</param>
        /// <param name="key">The key itself that is associated with the hot key.</param>
        public void RegisterHotKey(Keys key)
        {
            // increment the counter.
            _currentId = _currentId + 1;

            // register the hot key.
            RegisterHotKey(_window.Handle, _currentId, 0, (uint)key);
            //if (!RegisterHotKey(_window.Handle, _currentId, 0, (uint)key))
            //    throw new InvalidOperationException("Couldn’t register the hot key.");
        }

        /// <summary>
        /// A hot key has been pressed.
        /// </summary>
#pragma warning disable CS0436 // Type conflicts with imported type
        public event EventHandler<KeyPressedEventArgs> KeyPressed;
#pragma warning restore CS0436 // Type conflicts with imported type

        #region IDisposable Members

        public void Dispose()
        {
            // unregister all the registered hot keys.
            for (var i = _currentId; i > 0; i--)
            {
                UnregisterHotKey(_window.Handle, i);
            }

            // dispose the inner native window.
            _window.Dispose();
        }

        #endregion
    }

    /// <summary>
    /// Event Args for the event that is fired after the hot key has been pressed.
    /// </summary>
    public class KeyPressedEventArgs : EventArgs
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        internal KeyPressedEventArgs(ModifierKeys modifier, Keys key)
#pragma warning restore CS0436 // Type conflicts with imported type
        {
            Modifier = modifier;
            Key = key;
        }

#pragma warning disable CS0436 // Type conflicts with imported type
        public ModifierKeys Modifier { get; }
#pragma warning restore CS0436 // Type conflicts with imported type

        public Keys Key { get; }
    }

    /// <summary>
    /// The enumeration of possible modifiers.
    /// </summary>
    [Flags]
    public enum ModifierKeys : uint
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Win = 8
    }
}