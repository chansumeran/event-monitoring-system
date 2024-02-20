namespace Event_Monitoring_System
{
    partial class RemoveParticipantControl
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
            dataGridViewRemoveParticipants = new DataGridView();
            buttonRemoveParticipant = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRemoveParticipants).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRemoveParticipants
            // 
            dataGridViewRemoveParticipants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRemoveParticipants.BackgroundColor = Color.OldLace;
            dataGridViewRemoveParticipants.BorderStyle = BorderStyle.None;
            dataGridViewRemoveParticipants.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewRemoveParticipants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRemoveParticipants.GridColor = Color.OldLace;
            dataGridViewRemoveParticipants.Location = new Point(65, 138);
            dataGridViewRemoveParticipants.Name = "dataGridViewRemoveParticipants";
            dataGridViewRemoveParticipants.Size = new Size(589, 186);
            dataGridViewRemoveParticipants.TabIndex = 14;
            // 
            // buttonRemoveParticipant
            // 
            buttonRemoveParticipant.Location = new Point(297, 350);
            buttonRemoveParticipant.Name = "buttonRemoveParticipant";
            buttonRemoveParticipant.Size = new Size(150, 43);
            buttonRemoveParticipant.TabIndex = 15;
            buttonRemoveParticipant.Text = "Remove participant";
            buttonRemoveParticipant.UseVisualStyleBackColor = true;
            buttonRemoveParticipant.Click += buttonRemoveParticipant_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 55);
            label1.Name = "label1";
            label1.Size = new Size(203, 23);
            label1.TabIndex = 16;
            label1.Text = " Remove participant";
            // 
            // RemoveParticipantControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            Controls.Add(label1);
            Controls.Add(buttonRemoveParticipant);
            Controls.Add(dataGridViewRemoveParticipants);
            Name = "RemoveParticipantControl";
            Size = new Size(753, 479);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRemoveParticipants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRemove;
        private DataGridView dataGridViewRemoveParticipants;
        private Button buttonRemoveParticipant;
        private Label label1;
    }
}
