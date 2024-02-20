namespace Event_Monitoring_System.Events
{
    partial class ShowParticipantsOfEventControl
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
            labelFilter = new Label();
            comboBoxEvents = new ComboBox();
            dataGridViewParticipantsOfEvent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParticipantsOfEvent).BeginInit();
            SuspendLayout();
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.BackColor = Color.Transparent;
            labelFilter.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFilter.Location = new Point(301, 70);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(127, 23);
            labelFilter.TabIndex = 0;
            labelFilter.Text = "Select event";
            // 
            // comboBoxEvents
            // 
            comboBoxEvents.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxEvents.FormattingEnabled = true;
            comboBoxEvents.ItemHeight = 15;
            comboBoxEvents.Location = new Point(252, 110);
            comboBoxEvents.Name = "comboBoxEvents";
            comboBoxEvents.Size = new Size(222, 23);
            comboBoxEvents.TabIndex = 1;
            comboBoxEvents.SelectedIndexChanged += comboBoxEvents_SelectedIndexChanged;
            // 
            // dataGridViewParticipantsOfEvent
            // 
            dataGridViewParticipantsOfEvent.AllowUserToAddRows = false;
            dataGridViewParticipantsOfEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewParticipantsOfEvent.BackgroundColor = Color.OldLace;
            dataGridViewParticipantsOfEvent.BorderStyle = BorderStyle.None;
            dataGridViewParticipantsOfEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParticipantsOfEvent.Location = new Point(131, 173);
            dataGridViewParticipantsOfEvent.Name = "dataGridViewParticipantsOfEvent";
            dataGridViewParticipantsOfEvent.Size = new Size(454, 149);
            dataGridViewParticipantsOfEvent.TabIndex = 2;
            // 
            // ShowParticipantsOfEventControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewParticipantsOfEvent);
            Controls.Add(comboBoxEvents);
            Controls.Add(labelFilter);
            Name = "ShowParticipantsOfEventControl";
            Size = new Size(753, 479);
            Load += ShowParticipantsOfEventControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewParticipantsOfEvent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFilter;
        private ComboBox comboBoxEvents;
        private DataGridView dataGridViewParticipantsOfEvent;
    }
}
