namespace MicrosoftAuth
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScopes = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnGetAuthCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthCode = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRefreshToken = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClientId";
            // 
            // txtClientId
            // 
            this.txtClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientId.Location = new System.Drawing.Point(97, 19);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(514, 20);
            this.txtClientId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Scopes";
            // 
            // txtScopes
            // 
            this.txtScopes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScopes.Location = new System.Drawing.Point(97, 55);
            this.txtScopes.Name = "txtScopes";
            this.txtScopes.Size = new System.Drawing.Size(514, 20);
            this.txtScopes.TabIndex = 1;
            this.txtScopes.Text = "Offline_Access User.Read Files.ReadWrite Mail.ReadWrite";
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 167);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(599, 274);
            this.txtOutput.TabIndex = 4;
            // 
            // btnAuth
            // 
            this.btnAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuth.Location = new System.Drawing.Point(423, 452);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(75, 23);
            this.btnAuth.TabIndex = 6;
            this.btnAuth.Text = "Auth";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnGetAuthCode
            // 
            this.btnGetAuthCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetAuthCode.Location = new System.Drawing.Point(522, 452);
            this.btnGetAuthCode.Name = "btnGetAuthCode";
            this.btnGetAuthCode.Size = new System.Drawing.Size(89, 23);
            this.btnGetAuthCode.TabIndex = 5;
            this.btnGetAuthCode.Text = "GetAuthCode";
            this.btnGetAuthCode.UseVisualStyleBackColor = true;
            this.btnGetAuthCode.Click += new System.EventHandler(this.btnGetAuthCode_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "AuthCode";
            // 
            // txtAuthCode
            // 
            this.txtAuthCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthCode.Location = new System.Drawing.Point(97, 91);
            this.txtAuthCode.Name = "txtAuthCode";
            this.txtAuthCode.Size = new System.Drawing.Size(514, 20);
            this.txtAuthCode.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(333, 452);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Refresh Token";
            // 
            // txtRefreshToken
            // 
            this.txtRefreshToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRefreshToken.Location = new System.Drawing.Point(97, 127);
            this.txtRefreshToken.Name = "txtRefreshToken";
            this.txtRefreshToken.Size = new System.Drawing.Size(514, 20);
            this.txtRefreshToken.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 487);
            this.Controls.Add(this.btnGetAuthCode);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtRefreshToken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtScopes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MicrosoftAuth 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScopes;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnGetAuthCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthCode;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRefreshToken;
    }
}

