namespace Itse1430.MovieLib.Host
{
    partial class MovieForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this._txtName = new System.Windows.Forms.TextBox();
            this.chkHasSeen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtReleaseYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtRunLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // _txtName
            // 
            this._txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtName.Location = new System.Drawing.Point(89, 48);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(484, 20);
            this._txtName.TabIndex = 0;
            this._txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingName);
            // 
            // chkHasSeen
            // 
            this.chkHasSeen.AutoSize = true;
            this.chkHasSeen.Location = new System.Drawing.Point(89, 153);
            this.chkHasSeen.Name = "chkHasSeen";
            this.chkHasSeen.Size = new System.Drawing.Size(79, 17);
            this.chkHasSeen.TabIndex = 4;
            this.chkHasSeen.Text = "Has Seen?";
            this.chkHasSeen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Release Year";
            // 
            // _txtReleaseYear
            // 
            this._txtReleaseYear.Location = new System.Drawing.Point(89, 74);
            this._txtReleaseYear.Name = "_txtReleaseYear";
            this._txtReleaseYear.Size = new System.Drawing.Size(121, 20);
            this._txtReleaseYear.TabIndex = 1;
            this._txtReleaseYear.TextChanged += new System.EventHandler(this._txtReleaseYear_TextChanged);
            this._txtReleaseYear.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingReleaseYear);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rating";
            // 
            // cbRating
            // 
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "G",
            "PG",
            "PG-13",
            "R"});
            this.cbRating.Location = new System.Drawing.Point(89, 100);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(121, 21);
            this.cbRating.TabIndex = 2;
            this.cbRating.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingRating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Run Length";
            // 
            // _txtRunLength
            // 
            this._txtRunLength.Location = new System.Drawing.Point(89, 127);
            this._txtRunLength.Name = "_txtRunLength";
            this._txtRunLength.Size = new System.Drawing.Size(121, 20);
            this._txtRunLength.TabIndex = 3;
            this._txtRunLength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidatingRunLength);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(295, 100);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(278, 232);
            this.txtDescription.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(417, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(498, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 404);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtRunLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._txtReleaseYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkHasSeen);
            this.Controls.Add(this._txtName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(604, 443);
            this.Name = "MovieForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Details";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtName;
        private System.Windows.Forms.CheckBox chkHasSeen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtReleaseYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtRunLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}