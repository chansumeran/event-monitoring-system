namespace Event_Monitoring_System.Events
{
    partial class RemoveEventControl
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
            comboBoxEvents = new ComboBox();
            btnDelete = new Button();
            labelRemoveEvent = new Label();
            SuspendLayout();
            // 
            // comboBoxEvents
            // 
            comboBoxEvents.FormattingEnabled = true;
            comboBoxEvents.Location = new Point(246, 172);
            comboBoxEvents.Name = "comboBoxEvents";
            comboBoxEvents.Size = new Size(234, 23);
            comboBoxEvents.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 33);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // labelRemoveEvent
            // 
            labelRemoveEvent.AutoSize = true;
            labelRemoveEvent.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRemoveEvent.Location = new Point(295, 117);
            labelRemoveEvent.Name = "labelRemoveEvent";
            labelRemoveEvent.Size = new Size(146, 23);
            labelRemoveEvent.TabIndex = 2;
            labelRemoveEvent.Text = "Remove event";
            // 
            // RemoveEventControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            Controls.Add(labelRemoveEvent);
            Controls.Add(btnDelete);
            Controls.Add(comboBoxEvents);
            Name = "RemoveEventControl";
            Size = new Size(753, 479);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxEvents;
        private Button btnDelete;
        private Label labelRemoveEvent;
    }
}
