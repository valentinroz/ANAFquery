namespace ANAFqueryDemo
{
    partial class MainForm
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
            this.btnSimpleQuery = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtSimpleQuery = new System.Windows.Forms.TextBox();
            this.btnMultipleQuery = new System.Windows.Forms.Button();
            this.txtMultipleQuery = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSimpleQuery
            // 
            this.btnSimpleQuery.Location = new System.Drawing.Point(12, 12);
            this.btnSimpleQuery.Name = "btnSimpleQuery";
            this.btnSimpleQuery.Size = new System.Drawing.Size(103, 23);
            this.btnSimpleQuery.TabIndex = 0;
            this.btnSimpleQuery.Text = "Simple Query";
            this.btnSimpleQuery.UseVisualStyleBackColor = true;
            this.btnSimpleQuery.Click += new System.EventHandler(this.btnSimpleQuery_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 92);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(776, 346);
            this.txtOutput.TabIndex = 1;
            // 
            // txtSimpleQuery
            // 
            this.txtSimpleQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSimpleQuery.Location = new System.Drawing.Point(122, 13);
            this.txtSimpleQuery.Name = "txtSimpleQuery";
            this.txtSimpleQuery.Size = new System.Drawing.Size(666, 20);
            this.txtSimpleQuery.TabIndex = 2;
            this.txtSimpleQuery.Text = "8915831";
            // 
            // btnMultipleQuery
            // 
            this.btnMultipleQuery.Location = new System.Drawing.Point(12, 41);
            this.btnMultipleQuery.Name = "btnMultipleQuery";
            this.btnMultipleQuery.Size = new System.Drawing.Size(103, 23);
            this.btnMultipleQuery.TabIndex = 3;
            this.btnMultipleQuery.Text = "Multiple Query";
            this.btnMultipleQuery.UseVisualStyleBackColor = true;
            this.btnMultipleQuery.Click += new System.EventHandler(this.btnMultipleQuery_Click);
            // 
            // txtMultipleQuery
            // 
            this.txtMultipleQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMultipleQuery.Location = new System.Drawing.Point(122, 44);
            this.txtMultipleQuery.Name = "txtMultipleQuery";
            this.txtMultipleQuery.Size = new System.Drawing.Size(666, 20);
            this.txtMultipleQuery.TabIndex = 4;
            this.txtMultipleQuery.Text = "8915831,5905159";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMultipleQuery);
            this.Controls.Add(this.btnMultipleQuery);
            this.Controls.Add(this.txtSimpleQuery);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSimpleQuery);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "ANAF Query Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleQuery;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtSimpleQuery;
        private System.Windows.Forms.Button btnMultipleQuery;
        private System.Windows.Forms.TextBox txtMultipleQuery;
    }
}

