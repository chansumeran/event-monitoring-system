namespace Event_Monitoring_System.Events
{
    partial class EventControl
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
            eventPanel1 = new Panel();
            labelEvent = new Label();
            buttonShow = new Button();
            buttonAddEvent = new Button();
            eventPanel2 = new Panel();
            buttonRemove = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            eventPanel1.SuspendLayout();
            eventPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // eventPanel1
            // 
            eventPanel1.BackColor = Color.Wheat;
            eventPanel1.Controls.Add(labelEvent);
            eventPanel1.Location = new Point(0, 0);
            eventPanel1.Name = "eventPanel1";
            eventPanel1.Size = new Size(728, 136);
            eventPanel1.TabIndex = 4;
            // 
            // labelEvent
            // 
            labelEvent.AutoSize = true;
            labelEvent.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEvent.Location = new Point(257, 52);
            labelEvent.Name = "labelEvent";
            labelEvent.Size = new Size(211, 23);
            labelEvent.TabIndex = 2;
            labelEvent.Text = "Event Configurations";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(304, 186);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(110, 41);
            buttonShow.TabIndex = 1;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonAddEvent
            // 
            buttonAddEvent.Location = new Point(150, 186);
            buttonAddEvent.Name = "buttonAddEvent";
            buttonAddEvent.Size = new Size(110, 41);
            buttonAddEvent.TabIndex = 0;
            buttonAddEvent.Text = "Add";
            buttonAddEvent.UseVisualStyleBackColor = true;
            buttonAddEvent.Click += buttonAddEvent_Click;
            // 
            // eventPanel2
            // 
            eventPanel2.BackColor = Color.OldLace;
            eventPanel2.Controls.Add(buttonRemove);
            eventPanel2.Controls.Add(buttonAddEvent);
            eventPanel2.Controls.Add(buttonShow);
            eventPanel2.Location = new Point(0, 132);
            eventPanel2.Name = "eventPanel2";
            eventPanel2.Size = new Size(728, 439);
            eventPanel2.TabIndex = 5;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(455, 186);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(110, 41);
            buttonRemove.TabIndex = 2;
            buttonRemove.Text = "Remove ";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // EventControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(eventPanel2);
            Controls.Add(eventPanel1);
            Name = "EventControl";
            Size = new Size(728, 571);
            eventPanel1.ResumeLayout(false);
            eventPanel1.PerformLayout();
            eventPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel eventPanel1;
        private Label labelEvent;
        private Button buttonShow;
        private Button buttonAddEvent;
        private Panel eventPanel2;
        private Button buttonRemove;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
