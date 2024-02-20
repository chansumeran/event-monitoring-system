namespace Event_Monitoring_System
{
    partial class Dashboard
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
            dashboardContainer = new SplitContainer();
            buttonEditResults = new Button();
            buttonParticipants = new Button();
            buttonEvents = new Button();
            ((System.ComponentModel.ISupportInitialize)dashboardContainer).BeginInit();
            dashboardContainer.Panel1.SuspendLayout();
            dashboardContainer.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardContainer
            // 
            dashboardContainer.Dock = DockStyle.Fill;
            dashboardContainer.Location = new Point(0, 0);
            dashboardContainer.Name = "dashboardContainer";
            // 
            // dashboardContainer.Panel1
            // 
            dashboardContainer.Panel1.Controls.Add(buttonEditResults);
            dashboardContainer.Panel1.Controls.Add(buttonParticipants);
            dashboardContainer.Panel1.Controls.Add(buttonEvents);
            // 
            // dashboardContainer.Panel2
            // 
            dashboardContainer.Panel2.BackgroundImage = Properties.Resources.login_background;
            dashboardContainer.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
            dashboardContainer.Size = new Size(941, 571);
            dashboardContainer.SplitterDistance = 214;
            dashboardContainer.TabIndex = 0;
            // 
            // buttonEditResults
            // 
            buttonEditResults.Location = new Point(51, 296);
            buttonEditResults.Name = "buttonEditResults";
            buttonEditResults.Size = new Size(112, 43);
            buttonEditResults.TabIndex = 3;
            buttonEditResults.Text = "Results";
            buttonEditResults.UseVisualStyleBackColor = true;
            buttonEditResults.Click += buttonEditResults_Click;
            // 
            // buttonParticipants
            // 
            buttonParticipants.Location = new Point(51, 225);
            buttonParticipants.Name = "buttonParticipants";
            buttonParticipants.Size = new Size(112, 43);
            buttonParticipants.TabIndex = 1;
            buttonParticipants.Text = "Participants";
            buttonParticipants.UseVisualStyleBackColor = true;
            buttonParticipants.Click += buttonParticipants_Click;
            // 
            // buttonEvents
            // 
            buttonEvents.Location = new Point(51, 154);
            buttonEvents.Name = "buttonEvents";
            buttonEvents.Size = new Size(112, 43);
            buttonEvents.TabIndex = 0;
            buttonEvents.Text = "Events";
            buttonEvents.UseVisualStyleBackColor = true;
            buttonEvents.Click += buttonEvents_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 571);
            Controls.Add(dashboardContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            dashboardContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dashboardContainer).EndInit();
            dashboardContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer dashboardContainer;
        private Button buttonEditResults;
        private Button buttonParticipants;
        private Button buttonEvents;
    }
}