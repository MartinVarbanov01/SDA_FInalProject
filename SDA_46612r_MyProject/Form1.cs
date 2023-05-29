namespace SDA_46612r_MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            morseCodes.morse = morseCodes.morseBulgarian;
            MessageBox.Show("В момента сте на Български, изпозлва се българският морзов код");
        }

        MyTree treeMorse = new MyTree("bg");

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbText.Text == "" || tbMorse.Text == "")
            {
                MessageBox.Show("Не сте въвели данни");
                return;
            }
            string text = tbText.Text;
            string morse = tbMorse.Text;
            char[] test = morse.ToCharArray();
            foreach (char c in test)
            {
                if (c != '.' && c != '-')
                {
                    MessageBox.Show("Грешно въведен морзов код");
                    return;
                }
            }
            treeMorse.Add(morse, text);
            MessageBox.Show("Успешно добавен елемент");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int choise = 0;
            string key = "";
            foreach (char item in tbMorse.Text.ToCharArray())
            {
                if (item != '.' && item != '-')
                {
                    choise = 0;
                    break;
                }
                else
                {
                    choise = 1;
                }
            }
            if (morseCodes.morse.ContainsKey(tbText.Text.ToUpper()))
            {
                choise = 2;
            }
            if (choise == 1)
            {
                treeMorse.Find(tbMorse.Text);
                if (treeMorse.root.Value != null)
                    morseCodes.morse.Remove(treeMorse.root.Value);
                key = treeMorse.root.Value;
                treeMorse.root.Value = null;
                treeMorse.ReturnToRoot();
                MessageBox.Show(String.Format("Успешно премахнат елемент: {0}", key));
            }
            else if (choise == 2)
            {
                treeMorse.Remove(tbText.Text.ToUpper());
                key = morseCodes.morse[tbText.Text];
                morseCodes.morse.Remove(tbText.Text.ToUpper());
                MessageBox.Show(String.Format("Успешно премахнат елемент: {0}", key));
            }
            else
                MessageBox.Show("Няма такъв елемент");
        }

        private void btTranTo_Click(object sender, EventArgs e)
        {
            string s = "";
            if (tbText.Text != "")
            {
                foreach (char item in tbText.Text.ToUpper().ToCharArray())
                {
                    if (!morseCodes.morse.ContainsKey(item.ToString()) && item != ' ')
                    {
                        return;
                    }
                    else if (item == ' ')
                        s += "     ";
                    else
                        s += morseCodes.morse[item.ToString()] + "   ";
                }
                s += "\n";
                richTextBox1.Text += tbText.Text + "     " + s;
            }
            else
                MessageBox.Show("Полето с текс е празно");
        }

        private void btTranFrom_Click(object sender, EventArgs e)
        {
            string s = "";
            if (tbMorse.Text == "")
            {
                MessageBox.Show("Полето е празно");
                return;
            }
            foreach (char item in tbMorse.Text.ToCharArray())
            {
                if (item != '.' && item != '-' && item != ' ')
                {
                    return;
                }
            }
            string[] words = tbMorse.Text.Split(' ');
            foreach (string word in words)
            {
                s += treeMorse.translateFrom(word) + " ";
            }
            s += "\n";
            richTextBox1.Text += s;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btBG_Click(object sender, EventArgs e)
        {
            label1.Text = "Текст";
            label2.Text = "Морзов код";
            btAdd.Text = "Добави";
            btDelete.Text = "Изтрий";
            btTranTo.Text = "Преведи в Морзов";
            btTranFrom.Text = "Преведи от Морзов";
            btExit.Text = "Изход";
            MessageBox.Show("В момента сте на Български, изпозлва се българският морзов код");
            treeMorse = new MyTree("bg");
        }

        private void btEN_Click(object sender, EventArgs e)
        {
            label1.Text = "Text";
            label2.Text = "Morse Code";
            btAdd.Text = "Add";
            btDelete.Text = "Delete";
            btTranTo.Text = "Translate to Morse";
            btTranFrom.Text = "Translate from Morse";
            btExit.Text = "Exit";
            MessageBox.Show("You are currently in English, the English Morse code is used");
            treeMorse = new MyTree("en");
        }
    }

    public static class morseCodes
    {
        public static Dictionary<string, String> morse = new Dictionary<string, String>();

        public static Dictionary<string, String> morseEnglish = new Dictionary<string, String>()
            {
                {"A" , ".-"},
                {"B" , "-..."},
                {"C" , "-.-."},
                {"D" , "-.."},
                {"E" , "."},
                {"F" , "..-."},
                {"G" , "--."},
                {"H" , "...."},
                {"I" , ".."},
                {"J" , ".---"},
                {"K" , "-.-"},
                {"L" , ".-.."},
                {"M" , "--"},
                {"N" , "-."},
                {"O" , "---"},
                {"P" , ".--."},
                {"Q" , "--.-"},
                {"R" , ".-."},
                {"S" , "..."},
                {"T" , "-"},
                {"U" , "..-"},
                {"V" , "...-"},
                {"W" , ".--"},
                {"X" , "-..-"},
                {"Y" , "-.--"},
                {"Z" , "--.."},
                {"0" , "-----"},
                {"1" , ".----"},
                {"2" , "..---"},
                {"3" , "...--"},
                {"4" , "....-"},
                {"5" , "....."},
                {"6" , "-...."},
                {"7" , "--..."},
                {"8" , "---.."},
                {"9" , "----."},
            };
        public static Dictionary<string, String> morseBulgarian = new Dictionary<string, String>()
            {
                {"А" , ".-"},
                {"Б" , "-..."},
                {"В" , ".--"},
                {"Г" , "--."},
                {"Д" , "-.."},
                {"Е" , "."},
                {"Ж" , "...-"},
                {"З" , "--.."},
                {"И" , ".."},
                {"Ѝ" , ".---"},
                {"К" , "-.-"},
                {"Л" , ".-.."},
                {"М" , "--"},
                {"Н" , "-."},
                {"О" , "---"},
                {"П" , ".--."},
                {"Р" , ".-."},
                {"С" , "..."},
                {"Т" , "-"},
                {"У" , "..-"},
                {"Ф" , "..-."},
                {"Х" , "...."},
                {"Ц" , "-.-."},
                {"Ч" , "---."},
                {"Ш" , "----"},
                {"Щ" , "--.-"},
                {"Ъ" , "-..-"},
                {"Ь" , "-.--"},
                {"Ю" , "..--"},
                {"Я" , ".-.-"},
                {"0" , "-----"},
                {"1" , ".----"},
                {"2" , "..---"},
                {"3" , "...--"},
                {"4" , "....-"},
                {"5" , "....."},
                {"6" , "-...."},
                {"7" , "--..."},
                {"8" , "---.."},
                {"9" , "----."},
            };
    }

    public class Branch
    {
        public string? Value;
        public Branch? parent;
        public Branch? leftBranch;
        public Branch? rightBranch;

        public Branch()
        {
            Value = null;
            leftBranch = null;
            rightBranch = null;
        }
        public Branch(string item)
        {
            Value = item;
            leftBranch = null;
            rightBranch = null;
        }
    }

    public class MyTree
    {
        public Branch root = new Branch("root");
        public MyTree(string l)
        {
            if (l == "en")
                morseCodes.morse = morseCodes.morseEnglish;
            if (l == "bg")
                morseCodes.morse = morseCodes.morseBulgarian;
            foreach (var code in morseCodes.morse)
            {
                Find(code.Value);
                if (root.Value == null)
                {
                    root.Value = code.Key;
                }
                else
                {
                    MessageBox.Show("Вече има такава буква или такъв код");
                }
                ReturnToRoot();
            }
        }

        public void Find(string code)
        {
            char[] values = code.ToCharArray();
            foreach (char c in values)
            {
                if (c == '-')
                {
                    if (root.rightBranch != null)
                    {
                        root = root.rightBranch;
                    }
                    else
                    {
                        Branch newBranch = new Branch();
                        newBranch.parent = root;
                        root.rightBranch = newBranch;
                        root = root.rightBranch;
                    }
                }
                if (c == '.')
                {
                    if (root.leftBranch != null)
                    {
                        root = root.leftBranch;
                    }
                    else
                    {
                        Branch newBranch = new Branch();
                        newBranch.parent = root;
                        root.leftBranch = newBranch;
                        root = root.leftBranch;
                    }
                }
            }
        }

        public void ReturnToRoot()
        {
            while (root.Value != "root")
            {
                root = root.parent;
            }
        }
        public void Add(string code, string value)
        {
            //char[] values = new char[item.Length];
            Find(code);
            if (root.Value == null && !morseCodes.morse.ContainsKey(value))
            {
                root.Value = value;
                morseCodes.morse.Add(value, code);
            }
            else
            {
                MessageBox.Show("Вече има такава буква или такъв код");
            }
            ReturnToRoot();
        }
        public void Remove(string key)
        {
            if (morseCodes.morse.ContainsKey(key))
            {
                Find(morseCodes.morse[key]);
                root.Value = null;
                morseCodes.morse.Remove(key);
                ReturnToRoot();
            }
            else
                MessageBox.Show("Няма такъв ключ");
        }
        public string translateFrom(string values)
        {
            string? s = "";
            Find(values);
            s = root.Value;
            ReturnToRoot();
            if (s == null)
                return "_";
            else if (s == "root") return " ";
            return s;

        }
    }
}
