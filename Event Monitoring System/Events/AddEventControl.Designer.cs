namespace Event_Monitoring_System.Events
{
    partial class AddEventControl
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
            labelEventName = new Label();
            txtEventName = new TextBox();
            buttonSaveEvent = new Button();
            SuspendLayout();
            // 
            // labelEventName
            // 
            labelEventName.AutoSize = true;
            labelEventName.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEventName.Location = new Point(304, 116);
            labelEventName.Name = "labelEventName";
            labelEventName.Size = new Size(122, 23);
            labelEventName.TabIndex = 0;
            labelEventName.Text = "Event name";
            // 
            // txtEventName
            // 
            txtEventName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEventName.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEventName.Location = new Point(246, 172);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(234, 22);
            txtEventName.TabIndex = 1;
            // 
            // buttonSaveEvent
            // 
            buttonSaveEvent.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSaveEvent.Location = new Point(304, 222);
            buttonSaveEvent.Name = "buttonSaveEvent";
            buttonSaveEvent.Size = new Size(122, 33);
            buttonSaveEvent.TabIndex = 2;
            buttonSaveEvent.Text = "Save";
            buttonSaveEvent.UseVisualStyleBackColor = true;
            buttonSaveEvent.Click += buttonSaveEvent_Click;
            // 
            // AddEventControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            Controls.Add(buttonSaveEvent);
            Controls.Add(txtEventName);
            Controls.Add(labelEventName);
            Name = "AddEventControl";
            Size = new Size(753, 479);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEventName;
        private TextBox txtEventName;
        private Button buttonSaveEvent;
    }
}
