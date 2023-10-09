namespace Anketa
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
            panelAnket = new Panel();
            labelBirthDay = new Label();
            birthDay = new DateTimePicker();
            textEmail = new TextBox();
            labelEmail = new Label();
            rBtnFemale = new RadioButton();
            rBtnMale = new RadioButton();
            labelGender = new Label();
            btnSave = new Button();
            labelPhone = new Label();
            textPhone = new TextBox();
            textCity = new TextBox();
            labelCity = new Label();
            textCounty = new TextBox();
            labelCountry = new Label();
            textFatherName = new TextBox();
            labelFatherName = new Label();
            textSurname = new TextBox();
            labelSurname = new Label();
            textName = new TextBox();
            labelName = new Label();
            labelAnket = new Label();
            panelAnket.SuspendLayout();
            SuspendLayout();
            // 
            // panelAnket
            // 
            panelAnket.BackColor = Color.Silver;
            panelAnket.Controls.Add(labelBirthDay);
            panelAnket.Controls.Add(birthDay);
            panelAnket.Controls.Add(textEmail);
            panelAnket.Controls.Add(labelEmail);
            panelAnket.Controls.Add(rBtnFemale);
            panelAnket.Controls.Add(rBtnMale);
            panelAnket.Controls.Add(labelGender);
            panelAnket.Controls.Add(btnSave);
            panelAnket.Controls.Add(labelPhone);
            panelAnket.Controls.Add(textPhone);
            panelAnket.Controls.Add(textCity);
            panelAnket.Controls.Add(labelCity);
            panelAnket.Controls.Add(textCounty);
            panelAnket.Controls.Add(labelCountry);
            panelAnket.Controls.Add(textFatherName);
            panelAnket.Controls.Add(labelFatherName);
            panelAnket.Controls.Add(textSurname);
            panelAnket.Controls.Add(labelSurname);
            panelAnket.Controls.Add(textName);
            panelAnket.Controls.Add(labelName);
            panelAnket.Location = new Point(12, 32);
            panelAnket.Name = "panelAnket";
            panelAnket.Size = new Size(508, 559);
            panelAnket.TabIndex = 0;
            // 
            // labelBirthDay
            // 
            labelBirthDay.AutoSize = true;
            labelBirthDay.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirthDay.Location = new Point(21, 453);
            labelBirthDay.Name = "labelBirthDay";
            labelBirthDay.Size = new Size(88, 25);
            labelBirthDay.TabIndex = 37;
            labelBirthDay.Text = "BirthDay";
            // 
            // birthDay
            // 
            birthDay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            birthDay.Format = DateTimePickerFormat.Custom;
            birthDay.ImeMode = ImeMode.NoControl;
            birthDay.Location = new Point(157, 451);
            birthDay.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            birthDay.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            birthDay.Name = "birthDay";
            birthDay.Size = new Size(250, 27);
            birthDay.TabIndex = 36;
            birthDay.Tag = "";
            birthDay.Value = new DateTime(2023, 10, 8, 0, 0, 0, 0);
            // 
            // textEmail
            // 
            textEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textEmail.Location = new Point(157, 399);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(250, 30);
            textEmail.TabIndex = 35;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(21, 401);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(60, 28);
            labelEmail.TabIndex = 34;
            labelEmail.Text = "Email";
            // 
            // rBtnFemale
            // 
            rBtnFemale.AutoSize = true;
            rBtnFemale.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rBtnFemale.Location = new Point(235, 518);
            rBtnFemale.Name = "rBtnFemale";
            rBtnFemale.Size = new Size(88, 27);
            rBtnFemale.TabIndex = 33;
            rBtnFemale.TabStop = true;
            rBtnFemale.Text = "Female";
            rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // rBtnMale
            // 
            rBtnMale.AutoSize = true;
            rBtnMale.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rBtnMale.Location = new Point(157, 518);
            rBtnMale.Name = "rBtnMale";
            rBtnMale.Size = new Size(69, 27);
            rBtnMale.TabIndex = 32;
            rBtnMale.TabStop = true;
            rBtnMale.Text = "Male";
            rBtnMale.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGender.Location = new Point(21, 515);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(79, 28);
            labelGender.TabIndex = 31;
            labelGender.Text = "Gender";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSave.Location = new Point(405, 501);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 55);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += Save_Checking;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhone.Location = new Point(21, 343);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(77, 30);
            labelPhone.TabIndex = 29;
            labelPhone.Text = "Phone";
            // 
            // textPhone
            // 
            textPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textPhone.Location = new Point(157, 343);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(250, 30);
            textPhone.TabIndex = 28;
            // 
            // textCity
            // 
            textCity.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textCity.Location = new Point(157, 283);
            textCity.Name = "textCity";
            textCity.Size = new Size(250, 30);
            textCity.TabIndex = 27;
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelCity.Location = new Point(21, 283);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(52, 30);
            labelCity.TabIndex = 26;
            labelCity.Text = "City";
            // 
            // textCounty
            // 
            textCounty.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textCounty.Location = new Point(157, 229);
            textCounty.Name = "textCounty";
            textCounty.Size = new Size(250, 30);
            textCounty.TabIndex = 25;
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelCountry.Location = new Point(16, 229);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(94, 30);
            labelCountry.TabIndex = 24;
            labelCountry.Text = "Country";
            // 
            // textFatherName
            // 
            textFatherName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textFatherName.Location = new Point(157, 144);
            textFatherName.Name = "textFatherName";
            textFatherName.Size = new Size(250, 30);
            textFatherName.TabIndex = 23;
            // 
            // labelFatherName
            // 
            labelFatherName.AutoSize = true;
            labelFatherName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelFatherName.Location = new Point(16, 149);
            labelFatherName.Name = "labelFatherName";
            labelFatherName.Size = new Size(121, 25);
            labelFatherName.TabIndex = 22;
            labelFatherName.Text = "FatherName";
            // 
            // textSurname
            // 
            textSurname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textSurname.Location = new Point(157, 82);
            textSurname.Name = "textSurname";
            textSurname.Size = new Size(250, 30);
            textSurname.TabIndex = 21;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelSurname.Location = new Point(16, 84);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(93, 28);
            labelSurname.TabIndex = 20;
            labelSurname.Text = "Surname";
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(157, 23);
            textName.Name = "textName";
            textName.Size = new Size(250, 30);
            textName.TabIndex = 19;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelName.Location = new Point(16, 20);
            labelName.Name = "labelName";
            labelName.Size = new Size(72, 30);
            labelName.TabIndex = 18;
            labelName.Text = "Name";
            // 
            // labelAnket
            // 
            labelAnket.AutoSize = true;
            labelAnket.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelAnket.Location = new Point(12, 6);
            labelAnket.Name = "labelAnket";
            labelAnket.Size = new Size(58, 23);
            labelAnket.TabIndex = 1;
            labelAnket.Text = "Anket";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(532, 603);
            Controls.Add(labelAnket);
            Controls.Add(panelAnket);
            Name = "Form1";
            Text = "Anket";
            panelAnket.ResumeLayout(false);
            panelAnket.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAnket;
        private Label labelCity;
        private TextBox textCounty;
        private Label labelCountry;
        private TextBox textFatherName;
        private Label labelFatherName;
        private TextBox textSurname;
        private Label labelSurname;
        private TextBox textName;
        private Label labelName;
        private Label labelAnket;
        private Label labelPhone;
        private TextBox textPhone;
        private TextBox textCity;
        private Button btnSave;
        private RadioButton rBtnMale;
        private Label labelGender;
        private Label labelEmail;
        private RadioButton rBtnFemale;
        private TextBox textEmail;
        private DateTimePicker birthDay;
        private Label labelBirthDay;
    }
}