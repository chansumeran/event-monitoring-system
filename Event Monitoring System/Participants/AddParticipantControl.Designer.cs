namespace Event_Monitoring_System
{
    partial class AddParticipantControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtCourse = new TextBox();
            txtYearLevel = new TextBox();
            labelFname = new Label();
            labelLname = new Label();
            labelAge = new Label();
            labelCourse = new Label();
            labelYearLevel = new Label();
            btnSaveParticipant = new Button();
            btnClear = new Button();
            comboEvents = new ComboBox();
            labelEvent = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(136, 113);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(222, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(451, 116);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(222, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(136, 159);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(222, 23);
            txtAge.TabIndex = 2;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(451, 159);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(222, 23);
            txtCourse.TabIndex = 3;
            // 
            // txtYearLevel
            // 
            txtYearLevel.Location = new Point(136, 205);
            txtYearLevel.Name = "txtYearLevel";
            txtYearLevel.Size = new Size(222, 23);
            txtYearLevel.TabIndex = 4;
            // 
            // labelFname
            // 
            labelFname.AutoSize = true;
            labelFname.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFname.Location = new Point(61, 116);
            labelFname.Name = "labelFname";
            labelFname.Size = new Size(65, 14);
            labelFname.TabIndex = 5;
            labelFname.Text = "First name";
            // 
            // labelLname
            // 
            labelLname.AutoSize = true;
            labelLname.Location = new Point(376, 119);
            labelLname.Name = "labelLname";
            labelLname.Size = new Size(61, 15);
            labelLname.TabIndex = 6;
            labelLname.Text = "Last name";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAge.Location = new Point(61, 162);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(27, 14);
            labelAge.TabIndex = 7;
            labelAge.Text = "Age";
            // 
            // labelCourse
            // 
            labelCourse.AutoSize = true;
            labelCourse.Location = new Point(376, 162);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(44, 15);
            labelCourse.TabIndex = 8;
            labelCourse.Text = "Course";
            // 
            // labelYearLevel
            // 
            labelYearLevel.AutoSize = true;
            labelYearLevel.Location = new Point(61, 208);
            labelYearLevel.Name = "labelYearLevel";
            labelYearLevel.Size = new Size(56, 15);
            labelYearLevel.TabIndex = 9;
            labelYearLevel.Text = "Year level";
            // 
            // btnSaveParticipant
            // 
            btnSaveParticipant.Location = new Point(254, 257);
            btnSaveParticipant.Name = "btnSaveParticipant";
            btnSaveParticipant.Size = new Size(104, 38);
            btnSaveParticipant.TabIndex = 10;
            btnSaveParticipant.Text = "Save";
            btnSaveParticipant.UseVisualStyleBackColor = true;
            btnSaveParticipant.Click += btnSaveParticipant_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(376, 257);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 38);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // comboEvents
            // 
            comboEvents.FormattingEnabled = true;
            comboEvents.Location = new Point(451, 205);
            comboEvents.Name = "comboEvents";
            comboEvents.Size = new Size(222, 23);
            comboEvents.TabIndex = 13;
            comboEvents.Text = "Pick an event";
            // 
            // labelEvent
            // 
            labelEvent.AutoSize = true;
            labelEvent.Location = new Point(376, 208);
            labelEvent.Name = "labelEvent";
            labelEvent.Size = new Size(36, 15);
            labelEvent.TabIndex = 14;
            labelEvent.Text = "Event";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 55);
            label1.Name = "label1";
            label1.Size = new Size(157, 23);
            label1.TabIndex = 15;
            label1.Text = "Add participant";
            // 
            // AddParticipantControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label1);
            Controls.Add(labelEvent);
            Controls.Add(comboEvents);
            Controls.Add(btnClear);
            Controls.Add(btnSaveParticipant);
            Controls.Add(labelYearLevel);
            Controls.Add(labelCourse);
            Controls.Add(labelAge);
            Controls.Add(labelLname);
            Controls.Add(labelFname);
            Controls.Add(txtYearLevel);
            Controls.Add(txtCourse);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            DoubleBuffered = true;
            Name = "AddParticipantControl";
            Size = new Size(753, 479);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtCourse;
        private TextBox txtYearLevel;
        private Label labelFname;
        private Label labelLname;
        private Label labelAge;
        private Label labelCourse;
        private Label labelYearLevel;
        private Button btnSaveParticipant;
        private Button btnClear;
        private ComboBox comboEvents;
        private Label labelEvent;
        private Label label1;
    }
}
