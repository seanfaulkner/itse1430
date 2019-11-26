namespace CharacterCreator
{
    partial class NewCharForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.Name = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelProfession = new System.Windows.Forms.Label();
            this.labelRace = new System.Windows.Forms.Label();
            this.labelAttributes = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxProfession = new System.Windows.Forms.ComboBox();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.Strength = new System.Windows.Forms.NumericUpDown();
            this.labelStrength = new System.Windows.Forms.Label();
            this.labelIntelligence = new System.Windows.Forms.Label();
            this.labelAgility = new System.Windows.Forms.Label();
            this.labelConstitution = new System.Windows.Forms.Label();
            this.labelCharisma = new System.Windows.Forms.Label();
            this.Intelligence = new System.Windows.Forms.NumericUpDown();
            this.Agility = new System.Windows.Forms.NumericUpDown();
            this.Constitution = new System.Windows.Forms.NumericUpDown();
            this.Charisma = new System.Windows.Forms.NumericUpDown();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Strength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Constitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Charisma)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name.Location = new System.Drawing.Point(81, 69);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(480, 20);
            this.Name.TabIndex = 0;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(40, 72);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Location = new System.Drawing.Point(19, 110);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(56, 13);
            this.labelProfession.TabIndex = 2;
            this.labelProfession.Text = "Profession";
            // 
            // labelRace
            // 
            this.labelRace.AutoSize = true;
            this.labelRace.Location = new System.Drawing.Point(42, 138);
            this.labelRace.Name = "labelRace";
            this.labelRace.Size = new System.Drawing.Size(33, 13);
            this.labelRace.TabIndex = 4;
            this.labelRace.Text = "Race";
            // 
            // labelAttributes
            // 
            this.labelAttributes.AutoSize = true;
            this.labelAttributes.Location = new System.Drawing.Point(24, 168);
            this.labelAttributes.Name = "labelAttributes";
            this.labelAttributes.Size = new System.Drawing.Size(51, 13);
            this.labelAttributes.TabIndex = 6;
            this.labelAttributes.Text = "Attributes";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(267, 110);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(449, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBoxProfession
            // 
            this.comboBoxProfession.FormattingEnabled = true;
            this.comboBoxProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this.comboBoxProfession.Location = new System.Drawing.Point(82, 107);
            this.comboBoxProfession.Name = "comboBoxProfession";
            this.comboBoxProfession.Size = new System.Drawing.Size(154, 21);
            this.comboBoxProfession.TabIndex = 11;
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this.comboBoxRace.Location = new System.Drawing.Point(82, 135);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(154, 21);
            this.comboBoxRace.TabIndex = 12;
            // 
            // Strength
            // 
            this.Strength.Location = new System.Drawing.Point(82, 191);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(120, 20);
            this.Strength.TabIndex = 13;
            this.Strength.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Strength.ValueChanged += new System.EventHandler(this.Strength_ValueChanged);
            // 
            // labelStrength
            // 
            this.labelStrength.AutoSize = true;
            this.labelStrength.Location = new System.Drawing.Point(28, 193);
            this.labelStrength.Name = "labelStrength";
            this.labelStrength.Size = new System.Drawing.Size(47, 13);
            this.labelStrength.TabIndex = 14;
            this.labelStrength.Text = "Strength";
            // 
            // labelIntelligence
            // 
            this.labelIntelligence.AutoSize = true;
            this.labelIntelligence.Location = new System.Drawing.Point(12, 225);
            this.labelIntelligence.Name = "labelIntelligence";
            this.labelIntelligence.Size = new System.Drawing.Size(61, 13);
            this.labelIntelligence.TabIndex = 15;
            this.labelIntelligence.Text = "Intelligence";
            // 
            // labelAgility
            // 
            this.labelAgility.AutoSize = true;
            this.labelAgility.Location = new System.Drawing.Point(39, 251);
            this.labelAgility.Name = "labelAgility";
            this.labelAgility.Size = new System.Drawing.Size(34, 13);
            this.labelAgility.TabIndex = 16;
            this.labelAgility.Text = "Agility";
            // 
            // labelConstitution
            // 
            this.labelConstitution.AutoSize = true;
            this.labelConstitution.Location = new System.Drawing.Point(11, 278);
            this.labelConstitution.Name = "labelConstitution";
            this.labelConstitution.Size = new System.Drawing.Size(62, 13);
            this.labelConstitution.TabIndex = 17;
            this.labelConstitution.Text = "Constitution";
            // 
            // labelCharisma
            // 
            this.labelCharisma.AutoSize = true;
            this.labelCharisma.Location = new System.Drawing.Point(23, 305);
            this.labelCharisma.Name = "labelCharisma";
            this.labelCharisma.Size = new System.Drawing.Size(50, 13);
            this.labelCharisma.TabIndex = 18;
            this.labelCharisma.Text = "Charisma";
            // 
            // Intelligence
            // 
            this.Intelligence.Location = new System.Drawing.Point(82, 223);
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Size = new System.Drawing.Size(120, 20);
            this.Intelligence.TabIndex = 19;
            this.Intelligence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Agility
            // 
            this.Agility.Location = new System.Drawing.Point(82, 249);
            this.Agility.Name = "Agility";
            this.Agility.Size = new System.Drawing.Size(120, 20);
            this.Agility.TabIndex = 20;
            this.Agility.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Constitution
            // 
            this.Constitution.Location = new System.Drawing.Point(82, 276);
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(120, 20);
            this.Constitution.TabIndex = 21;
            this.Constitution.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Charisma
            // 
            this.Charisma.Location = new System.Drawing.Point(82, 303);
            this.Charisma.Name = "Charisma";
            this.Charisma.Size = new System.Drawing.Size(120, 20);
            this.Charisma.TabIndex = 22;
            this.Charisma.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(327, 300);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(69, 23);
            this.Cancel.TabIndex = 23;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewCharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 346);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Charisma);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.Agility);
            this.Controls.Add(this.Intelligence);
            this.Controls.Add(this.labelCharisma);
            this.Controls.Add(this.labelConstitution);
            this.Controls.Add(this.labelAgility);
            this.Controls.Add(this.labelIntelligence);
            this.Controls.Add(this.labelStrength);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this.comboBoxRace);
            this.Controls.Add(this.comboBoxProfession);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAttributes);
            this.Controls.Add(this.labelRace);
            this.Controls.Add(this.labelProfession);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.Name);
            this.MinimumSize = new System.Drawing.Size(590, 385);
            this.Name = "NewCharForm";
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this.Strength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Constitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Charisma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelProfession;
        private System.Windows.Forms.Label labelRace;
        private System.Windows.Forms.Label labelAttributes;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxProfession;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.NumericUpDown Strength;
        private System.Windows.Forms.Label labelStrength;
        private System.Windows.Forms.Label labelIntelligence;
        private System.Windows.Forms.Label labelAgility;
        private System.Windows.Forms.Label labelConstitution;
        private System.Windows.Forms.Label labelCharisma;
        private System.Windows.Forms.NumericUpDown Intelligence;
        private System.Windows.Forms.NumericUpDown Agility;
        private System.Windows.Forms.NumericUpDown Constitution;
        private System.Windows.Forms.NumericUpDown Charisma;
        private System.Windows.Forms.Button Cancel;
    }
}