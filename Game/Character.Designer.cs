namespace Game
{
    partial class Character
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb = new System.Windows.Forms.PictureBox();
            this.Str = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.St = new System.Windows.Forms.ComboBox();
            this.Int = new System.Windows.Forms.ComboBox();
            this.Ag = new System.Windows.Forms.ComboBox();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblPer = new System.Windows.Forms.Label();
            this.lblAg = new System.Windows.Forms.Label();
            this.IntBn = new System.Windows.Forms.Label();
            this.AgBn = new System.Windows.Forms.Label();
            this.PerBn = new System.Windows.Forms.Label();
            this.StBn = new System.Windows.Forms.Label();
            this.StrBn = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Per = new System.Windows.Forms.ComboBox();
            this.HpBn = new System.Windows.Forms.Label();
            this.Fstr = new System.Windows.Forms.Label();
            this.Hp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.characterstrength = new System.Windows.Forms.Label();
            this.characterhealth = new System.Windows.Forms.Label();
            this.characterperception = new System.Windows.Forms.Label();
            this.characterstealth = new System.Windows.Forms.Label();
            this.characterintelligence = new System.Windows.Forms.Label();
            this.characteragility = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(308, 25);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(450, 276);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // Str
            // 
            this.Str.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Str.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Str.FormattingEnabled = true;
            this.Str.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "",
            "",
            "",
            ""});
            this.Str.Location = new System.Drawing.Point(121, 226);
            this.Str.Name = "Str";
            this.Str.Size = new System.Drawing.Size(121, 21);
            this.Str.TabIndex = 2;
            this.Str.SelectedIndexChanged += new System.EventHandler(this.Str_SelectedIndexChanged);
            // 
            // Class
            // 
            this.Class.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
            "Ninja",
            "Samurai",
            "Ronin",
            "Monk"});
            this.Class.Location = new System.Drawing.Point(122, 58);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(121, 21);
            this.Class.TabIndex = 3;
            this.Class.SelectedIndexChanged += new System.EventHandler(this.Class_SelectedIndexChanged);
            // 
            // St
            // 
            this.St.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.St.FormattingEnabled = true;
            this.St.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.St.Location = new System.Drawing.Point(121, 306);
            this.St.Name = "St";
            this.St.Size = new System.Drawing.Size(121, 21);
            this.St.TabIndex = 5;
            this.St.SelectedIndexChanged += new System.EventHandler(this.St_SelectedIndexChanged);
            // 
            // Int
            // 
            this.Int.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Int.FormattingEnabled = true;
            this.Int.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Int.Location = new System.Drawing.Point(122, 279);
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(121, 21);
            this.Int.TabIndex = 6;
            this.Int.SelectedIndexChanged += new System.EventHandler(this.Int_SelectedIndexChanged);
            // 
            // Ag
            // 
            this.Ag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ag.FormattingEnabled = true;
            this.Ag.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Ag.Location = new System.Drawing.Point(122, 252);
            this.Ag.Name = "Ag";
            this.Ag.Size = new System.Drawing.Size(121, 21);
            this.Ag.TabIndex = 7;
            this.Ag.SelectedIndexChanged += new System.EventHandler(this.Ag_SelectedIndexChanged);
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStr.Location = new System.Drawing.Point(24, 225);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(85, 22);
            this.lblStr.TabIndex = 10;
            this.lblStr.Text = "Strength";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClass.Location = new System.Drawing.Point(56, 58);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(55, 22);
            this.lblClass.TabIndex = 11;
            this.lblClass.Text = "Class";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHp.Location = new System.Drawing.Point(45, 357);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(68, 22);
            this.lblHp.TabIndex = 12;
            this.lblHp.Text = "Health";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInt.Location = new System.Drawing.Point(3, 279);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(113, 22);
            this.lblInt.TabIndex = 13;
            this.lblInt.Text = "Intelligence";
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPer.Location = new System.Drawing.Point(5, 333);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(106, 22);
            this.lblPer.TabIndex = 14;
            this.lblPer.Text = "Perception";
            // 
            // lblAg
            // 
            this.lblAg.AutoSize = true;
            this.lblAg.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAg.Location = new System.Drawing.Point(42, 252);
            this.lblAg.Name = "lblAg";
            this.lblAg.Size = new System.Drawing.Size(67, 22);
            this.lblAg.TabIndex = 15;
            this.lblAg.Text = "Agility";
            // 
            // IntBn
            // 
            this.IntBn.AutoSize = true;
            this.IntBn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntBn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IntBn.Location = new System.Drawing.Point(249, 278);
            this.IntBn.Name = "IntBn";
            this.IntBn.Size = new System.Drawing.Size(0, 22);
            this.IntBn.TabIndex = 17;
            // 
            // AgBn
            // 
            this.AgBn.AutoSize = true;
            this.AgBn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgBn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgBn.Location = new System.Drawing.Point(249, 252);
            this.AgBn.Name = "AgBn";
            this.AgBn.Size = new System.Drawing.Size(0, 22);
            this.AgBn.TabIndex = 18;
            // 
            // PerBn
            // 
            this.PerBn.AutoSize = true;
            this.PerBn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerBn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PerBn.Location = new System.Drawing.Point(248, 333);
            this.PerBn.Name = "PerBn";
            this.PerBn.Size = new System.Drawing.Size(0, 22);
            this.PerBn.TabIndex = 19;
            // 
            // StBn
            // 
            this.StBn.AutoSize = true;
            this.StBn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StBn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StBn.Location = new System.Drawing.Point(248, 306);
            this.StBn.Name = "StBn";
            this.StBn.Size = new System.Drawing.Size(0, 22);
            this.StBn.TabIndex = 20;
            // 
            // StrBn
            // 
            this.StrBn.AutoSize = true;
            this.StrBn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrBn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StrBn.Location = new System.Drawing.Point(249, 221);
            this.StrBn.Name = "StrBn";
            this.StrBn.Size = new System.Drawing.Size(0, 22);
            this.StrBn.TabIndex = 21;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Create.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Create.Location = new System.Drawing.Point(308, 401);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(109, 39);
            this.Create.TabIndex = 22;
            this.Create.Text = "Finish";
            this.Create.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(56, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Stealth";
            // 
            // Per
            // 
            this.Per.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Per.FormattingEnabled = true;
            this.Per.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Per.Location = new System.Drawing.Point(121, 333);
            this.Per.Name = "Per";
            this.Per.Size = new System.Drawing.Size(121, 21);
            this.Per.TabIndex = 25;
            this.Per.SelectedIndexChanged += new System.EventHandler(this.Per_SelectedIndexChanged);
            // 
            // HpBn
            // 
            this.HpBn.AutoSize = true;
            this.HpBn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HpBn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HpBn.Location = new System.Drawing.Point(146, 357);
            this.HpBn.Name = "HpBn";
            this.HpBn.Size = new System.Drawing.Size(0, 22);
            this.HpBn.TabIndex = 26;
            // 
            // Fstr
            // 
            this.Fstr.AutoSize = true;
            this.Fstr.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fstr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fstr.Location = new System.Drawing.Point(304, 329);
            this.Fstr.Name = "Fstr";
            this.Fstr.Size = new System.Drawing.Size(67, 22);
            this.Fstr.TabIndex = 27;
            this.Fstr.Text = "Agility";
            // 
            // Hp
            // 
            this.Hp.AutoSize = true;
            this.Hp.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Hp.Location = new System.Drawing.Point(118, 357);
            this.Hp.Name = "Hp";
            this.Hp.Size = new System.Drawing.Size(32, 22);
            this.Hp.TabIndex = 28;
            this.Hp.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(445, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Perception";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(445, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Stealth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(304, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Intelligence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(304, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Strenght";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(445, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "health";
            // 
            // characterstrength
            // 
            this.characterstrength.AutoSize = true;
            this.characterstrength.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterstrength.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.characterstrength.Location = new System.Drawing.Point(418, 311);
            this.characterstrength.Name = "characterstrength";
            this.characterstrength.Size = new System.Drawing.Size(21, 22);
            this.characterstrength.TabIndex = 40;
            this.characterstrength.Text = "1";
            // 
            // characterhealth
            // 
            this.characterhealth.AutoSize = true;
            this.characterhealth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterhealth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.characterhealth.Location = new System.Drawing.Point(557, 351);
            this.characterhealth.Name = "characterhealth";
            this.characterhealth.Size = new System.Drawing.Size(32, 22);
            this.characterhealth.TabIndex = 41;
            this.characterhealth.Text = "10";
            // 
            // characterperception
            // 
            this.characterperception.AutoSize = true;
            this.characterperception.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterperception.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.characterperception.Location = new System.Drawing.Point(557, 330);
            this.characterperception.Name = "characterperception";
            this.characterperception.Size = new System.Drawing.Size(21, 22);
            this.characterperception.TabIndex = 42;
            this.characterperception.Text = "1";
            // 
            // characterstealth
            // 
            this.characterstealth.AutoSize = true;
            this.characterstealth.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterstealth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.characterstealth.Location = new System.Drawing.Point(557, 308);
            this.characterstealth.Name = "characterstealth";
            this.characterstealth.Size = new System.Drawing.Size(21, 22);
            this.characterstealth.TabIndex = 43;
            this.characterstealth.Text = "1";
            // 
            // characterintelligence
            // 
            this.characterintelligence.AutoSize = true;
            this.characterintelligence.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterintelligence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.characterintelligence.Location = new System.Drawing.Point(418, 355);
            this.characterintelligence.Name = "characterintelligence";
            this.characterintelligence.Size = new System.Drawing.Size(21, 22);
            this.characterintelligence.TabIndex = 44;
            this.characterintelligence.Text = "1";
            // 
            // characteragility
            // 
            this.characteragility.AutoSize = true;
            this.characteragility.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characteragility.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.characteragility.Location = new System.Drawing.Point(418, 333);
            this.characteragility.Name = "characteragility";
            this.characteragility.Size = new System.Drawing.Size(21, 22);
            this.characteragility.TabIndex = 45;
            this.characteragility.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 46;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(869, 530);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.characteragility);
            this.Controls.Add(this.characterintelligence);
            this.Controls.Add(this.characterstealth);
            this.Controls.Add(this.characterperception);
            this.Controls.Add(this.characterhealth);
            this.Controls.Add(this.characterstrength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hp);
            this.Controls.Add(this.Fstr);
            this.Controls.Add(this.HpBn);
            this.Controls.Add(this.Per);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.StrBn);
            this.Controls.Add(this.StBn);
            this.Controls.Add(this.PerBn);
            this.Controls.Add(this.AgBn);
            this.Controls.Add(this.IntBn);
            this.Controls.Add(this.lblAg);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblHp);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.Ag);
            this.Controls.Add(this.Int);
            this.Controls.Add(this.St);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Str);
            this.Controls.Add(this.pb);
            this.Name = "Character";
            this.Load += new System.EventHandler(this.Character_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.ComboBox Str;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.ComboBox St;
        private System.Windows.Forms.ComboBox Int;
        private System.Windows.Forms.ComboBox Ag;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label lblAg;        
        private System.Windows.Forms.Label IntBn;
        private System.Windows.Forms.Label AgBn;
        private System.Windows.Forms.Label PerBn;
        private System.Windows.Forms.Label StBn;
        private System.Windows.Forms.Label StrBn;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Per;
        private System.Windows.Forms.Label HpBn;
        private System.Windows.Forms.Label Fstr;
        private System.Windows.Forms.Label Hp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label characterstrength;
        private System.Windows.Forms.Label characterhealth;
        private System.Windows.Forms.Label characterperception;
        private System.Windows.Forms.Label characterstealth;
        private System.Windows.Forms.Label characterintelligence;
        private System.Windows.Forms.Label characteragility;
        private System.Windows.Forms.TextBox textBox1;
    }
}