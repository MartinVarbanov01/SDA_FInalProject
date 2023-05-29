namespace SDA_46612r_MyProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbText = new TextBox();
            richTextBox1 = new RichTextBox();
            btAdd = new Button();
            btDelete = new Button();
            btTranTo = new Button();
            btTranFrom = new Button();
            btExit = new Button();
            tbMorse = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btBG = new Button();
            btEN = new Button();
            SuspendLayout();
            // 
            // tbText
            // 
            tbText.Location = new Point(91, 31);
            tbText.Name = "tbText";
            tbText.Size = new Size(128, 23);
            tbText.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(-1, 104);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(639, 291);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(242, 30);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 2;
            btAdd.Text = "Добави";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(242, 59);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 3;
            btDelete.Text = "Изтрий";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btTranTo
            // 
            btTranTo.Location = new Point(323, 30);
            btTranTo.Name = "btTranTo";
            btTranTo.Size = new Size(127, 23);
            btTranTo.TabIndex = 4;
            btTranTo.Text = "Преведи в Морзов";
            btTranTo.UseVisualStyleBackColor = true;
            btTranTo.Click += btTranTo_Click;
            // 
            // btTranFrom
            // 
            btTranFrom.Location = new Point(323, 59);
            btTranFrom.Name = "btTranFrom";
            btTranFrom.Size = new Size(127, 23);
            btTranFrom.TabIndex = 5;
            btTranFrom.Text = "Преведи от Морзов";
            btTranFrom.UseVisualStyleBackColor = true;
            btTranFrom.Click += btTranFrom_Click;
            // 
            // btExit
            // 
            btExit.Location = new Point(456, 30);
            btExit.Name = "btExit";
            btExit.Size = new Size(84, 52);
            btExit.TabIndex = 8;
            btExit.Text = "Изход";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // tbMorse
            // 
            tbMorse.Location = new Point(91, 59);
            tbMorse.Name = "tbMorse";
            tbMorse.Size = new Size(128, 23);
            tbMorse.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 10;
            label1.Text = "Текст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 11;
            label2.Text = "Морзов код";
            // 
            // btBG
            // 
            btBG.Location = new Point(546, 31);
            btBG.Name = "btBG";
            btBG.Size = new Size(75, 23);
            btBG.TabIndex = 12;
            btBG.Text = "Български";
            btBG.UseVisualStyleBackColor = true;
            btBG.Click += btBG_Click;
            // 
            // btEN
            // 
            btEN.Location = new Point(546, 58);
            btEN.Name = "btEN";
            btEN.Size = new Size(75, 23);
            btEN.TabIndex = 13;
            btEN.Text = "English";
            btEN.UseVisualStyleBackColor = true;
            btEN.Click += btEN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 395);
            Controls.Add(btEN);
            Controls.Add(btBG);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbMorse);
            Controls.Add(btExit);
            Controls.Add(btTranFrom);
            Controls.Add(btTranTo);
            Controls.Add(btDelete);
            Controls.Add(btAdd);
            Controls.Add(richTextBox1);
            Controls.Add(tbText);
            MaximumSize = new Size(655, 434);
            MinimumSize = new Size(655, 434);
            Name = "Form1";
            Text = "SDA_46612r_MyProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbText;
        private RichTextBox richTextBox1;
        private Button btAdd;
        private Button btDelete;
        private Button btTranTo;
        private Button btTranFrom;
        private Button btExit;
        private TextBox tbMorse;
        private Label label1;
        private Label label2;
        private Button btBG;
        private Button btEN;
    }
}