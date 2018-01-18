using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace QuickNote
{

    public partial class Form1 : Form, IDisposable
    {

        public List<Tag> TagList = new List<Tag>();
        public List<ContentNotes> NotesList = new List<ContentNotes>();
        string tagspath = "../tags.bat";
        string Notespath = "../Notes_";
        public Form1()
        {
            InitializeComponent();
            Boolean success = Form1.RegisterHotKey(this.Handle, this.GetType().GetHashCode(), 2, (int)Keys.Space); // đăng ký ctrl + Space để hiện chương trình

            // load tag từ file có sẵn
            LoadTags(tagspath);
            LoadNotes(Notespath);
            //BindingDataToCbxTag();
        }

        public void LoadNotes(string path)
        {
            int k = 0;
            string newpath = path + k.ToString() + ".bat";

            try
            {
                while (File.Exists(newpath))
                {
                    string[] notes = File.ReadAllLines(newpath);
                    if (notes.Length > 0)
                    {
                        notes[0] = notes[0].Trim(); // chuẩn hóa chuỗi 
                        List<string> tags = notes[0].Split(',').ToList();
                        string nd = "";
                        for (int i = 1; i < notes.Length; i++)
                        {
                            nd += notes[i] + "\r\n";
                        }
                        for (int i = 0; i < tags.Count; i++)
                        {
                            tags[i] = tags[i].Trim();
                        }
                        //ContentNotes temp = new ContentNotes(nd, tags);
                        NotesList.Add(new ContentNotes(nd, tags) { Content = nd, Tag = tags });
                    }
                    k++;
                    newpath = path + k.ToString() + ".bat";
                }

            }
            catch
            {

            }
        }
        // lấy danh sách các Tag từ file 
        void LoadTags(string path)
        {
            try
            {
                if (File.Exists(path))
                {

                    string[] tags = File.ReadAllLines(path);
                    if (tags.Length > 0)
                    {
                        foreach (string item in tags)
                        {
                            int i = item.LastIndexOf('(');
                            int ii = item.LastIndexOf(')');
                            string t = item.Substring(0, i).Trim();
                            string tt = item.Substring(i + 1, (ii - i - 1));
                            int c = Convert.ToInt32(tt);
                            Tag temp = new Tag(t, c);
                            TagList.Add(temp);

                        }

                        Sort(ref TagList);
                    }

                }
            }
            catch
            {

            }
        }


        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        //[DllImport("user32.dll")]
        //public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                //MessageBox.Show("Catched");//You can replace this statement with your desired response to the Hotkey.
                this.WindowState = FormWindowState.Normal;
                //this.ShowIcon = true;
                this.ShowInTaskbar = true;
                this.Show();
            }
            base.WndProc(ref m);
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fViewNotes fvn = new fViewNotes(TagList, NotesList);
            fvn.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            fChart fc = new fChart(TagList);
            fc.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ShowIcon = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void NFI_F1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            //this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Show();
        }

        

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txb_InputTag.Text == "")
            {
                ERP_InputTag.SetError(txb_InputTag, "Please type tags!!");
                return;
            }
            else if (txb_InputNote.Text == "")
            {
                ERP_InputTag.SetError(txb_InputNote, "Please type note content!!");
                return;
            }

            //thêm các tag vừa nhập vào TagsList
            AddTagToTagsList();
            Sort(ref TagList);
            //BindingDataToCbxTag();
            AddNoteToNotesList();

            // lưu vào file lưu trữ các Tag
            SaveToTagsFile();
            txb_InputTag.Clear();
            txb_InputNote.Clear();
            HideInputNote();
            //
        }
        public void SaveToNotesFile()
        {

        }
        public void AddNoteToNotesList()
        {
            string tag = txb_InputTag.Text;
            tag = tag.ToLower();
            tag = tag.Trim();
            List<string> tags = tag.Split(',').ToList(); // lấy mảng các note
            string nd = txb_InputNote.Text; // lẫy chuỗi chứa nội dung

            for (int i = 0; i < tags.Count; i++)
            {

                for (int j = i + 1; j < tags.Count; j++)
                {
                    if (tags[i] == tags[j])
                    {
                        tags.RemoveAt(j);
                        j--;
                    }
                }
                tags[i] = tags[i].Trim();
            }
            tag = String.Join(", ", tags.ToArray());
            NotesList.Add(new ContentNotes(nd, tags) { Content = nd, Tag = tags });
            int l = NotesList.Count - 1;

            string path = Notespath + l.ToString() + ".bat";
            using (Stream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);

                sw.WriteLine(tag);
                sw.WriteLine(nd);

                sw.Close();
            }

        }

        //sắp xếp lại tần số xuất hiện của các tags
        public void Sort(ref List<Tag> taglist)
        {
            for (int i = 0; i < taglist.Count; i++)
            {
                for (int j = 0; j < taglist.Count; j++)
                {
                    if (taglist[i].Count > taglist[j].Count)
                    {
                        Tag t = taglist[i];
                        taglist[i] = taglist[j];
                        taglist[j] = t;
                    }
                }
            }
        }

        public void AddTagToTagsList()
        {
            string tag = txb_InputTag.Text;
            tag = tag.ToLower();
            tag = tag.Trim();
            List<string> tags = tag.Split(',').ToList();

            for (int i = 0; i < tags.Count; i++)
            {
                tags[i] = tags[i].Trim();
            }
            // xóa các tag nhập trùng
            for (int i = 0; i < tags.Count; i++)
            {
                for (int j = i + 1; j < tags.Count; j++)
                {
                    if (tags[i] == tags[j])
                    {
                        tags.RemoveAt(j);
                        j--;
                    }
                }
            }
            //thêm số lượng tag vào tag đã có sẵn
            if (TagList.Count > 0) // nếu Taglist không rỗng 
            {
                for (int i = 0; i < tags.Count; i++)
                {
                    for (int j = 0; j < TagList.Count; j++)
                    {
                        if (tags[i] == TagList[j].Tags)
                        {
                            TagList[j].Count++;
                            break;
                        }
                        // nếu tag chưa tồn tại
                        if (j == TagList.Count - 1)
                        {
                            TagList.Add(new Tag(tags[i], 1) { Tags = tags[i], Count = 1 });
                            break;
                        }
                    }
                }
            }
            else // nếu taglist rỗng tức là chưa có tag nào
            {
                for (int i = 0; i < tags.Count; i++)
                {

                    TagList.Add(new Tag(tags[i], 1) { Tags = tags[i], Count = 1 });
                }
            }


        }

        void HideInputNote()
        {
            this.Hide();
        }

        public void SaveToTagsFile()
        {
            using (Stream fs = new FileStream(tagspath, FileMode.Create, FileAccess.Write))
            {

                StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);

                for (int i = 0; i < TagList.Count; i++)
                {
                    string temp = String.Format("{0} ({1})", TagList[i].Tags, TagList[i].Count);
                    sw.WriteLine(temp, 0, temp.Length);
                }
                sw.Close();
            }

        }



    }



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
                if (m.Msg == WM_HOTKEY)
                {
                    // get the keys.
                    Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                    ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 0xFFFF);

                    // invoke the event to notify the parent.
                    if (KeyPressed != null)
                        KeyPressed(this, new KeyPressedEventArgs(modifier, key));
                }
            }

            public event EventHandler<KeyPressedEventArgs> KeyPressed;

            #region IDisposable Members

            public void Dispose()
            {
                this.DestroyHandle();
            }

            #endregion
        }

        private Window _window = new Window();
        private int _currentId;

        public KeyboardHook()
        {
            // register the event of the inner native window.
            _window.KeyPressed += delegate (object sender, KeyPressedEventArgs args)
            {
                if (KeyPressed != null)
                    KeyPressed(this, args);
            };
        }

        /// <summary>
        /// Registers a hot key in the system.
        /// </summary>
        /// <param name="modifier">The modifiers that are associated with the hot key.</param>
        /// <param name="key">The key itself that is associated with the hot key.</param>
        public void RegisterHotKey(ModifierKeys modifier, Keys key)
        {
            // increment the counter.
            _currentId = _currentId + 1;

            // register the hot key.
            if (!RegisterHotKey(_window.Handle, _currentId, (uint)modifier, (uint)key))
                throw new InvalidOperationException("Couldn’t register the hot key.");
        }

        /// <summary>
        /// A hot key has been pressed.
        /// </summary>
        public event EventHandler<KeyPressedEventArgs> KeyPressed;

        #region IDisposable Members

        public void Dispose()
        {
            // unregister all the registered hot keys.
            for (int i = _currentId; i > 0; i--)
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
        private ModifierKeys _modifier;
        private Keys _key;

        internal KeyPressedEventArgs(ModifierKeys modifier, Keys key)
        {
            _modifier = modifier;
            _key = key;
        }

        public ModifierKeys Modifier
        {
            get { return _modifier; }
        }

        public Keys Key
        {
            get { return _key; }
        }
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
