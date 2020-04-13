namespace VSVersionChanger
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
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Form1 ) );
            this.cbVersions = new System.Windows.Forms.ComboBox();
            this.tbSlnLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnGetSln = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkBDelMinVersionInfo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbVersions
            // 
            this.cbVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersions.FormattingEnabled = true;
            this.cbVersions.Location = new System.Drawing.Point( 34, 102 );
            this.cbVersions.Name = "cbVersions";
            this.cbVersions.Size = new System.Drawing.Size( 329, 21 );
            this.cbVersions.TabIndex = 2;
            // 
            // tbSlnLoc
            // 
            this.tbSlnLoc.Location = new System.Drawing.Point( 34, 52 );
            this.tbSlnLoc.Name = "tbSlnLoc";
            this.tbSlnLoc.ReadOnly = true;
            this.tbSlnLoc.Size = new System.Drawing.Size( 292, 20 );
            this.tbSlnLoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 31, 19 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 159, 17 );
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Project Location*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label2.Location = new System.Drawing.Point( 31, 82 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 131, 17 );
            this.label2.TabIndex = 3;
            this.label2.Text = "Convert To Version*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font( "Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
            this.label3.Location = new System.Drawing.Point( 40, 36 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 173, 15 );
            this.label3.TabIndex = 4;
            this.label3.Text = "e.g: C:\\Users\\Documents\\VS\\UI";
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point( 253, 161 );
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size( 132, 31 );
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // btnGetSln
            // 
            this.btnGetSln.Image = ( ( System.Drawing.Image ) ( resources.GetObject( "btnGetSln.Image" ) ) );
            this.btnGetSln.Location = new System.Drawing.Point( 332, 50 );
            this.btnGetSln.Name = "btnGetSln";
            this.btnGetSln.Size = new System.Drawing.Size( 31, 23 );
            this.btnGetSln.TabIndex = 1;
            this.btnGetSln.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point( -5, 152 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 406, 3 );
            this.panel1.TabIndex = 7;
            // 
            // chkBDelMinVersionInfo
            // 
            this.chkBDelMinVersionInfo.AutoSize = true;
            this.chkBDelMinVersionInfo.Location = new System.Drawing.Point( 34, 130 );
            this.chkBDelMinVersionInfo.Name = "chkBDelMinVersionInfo";
            this.chkBDelMinVersionInfo.Size = new System.Drawing.Size( 151, 17 );
            this.chkBDelMinVersionInfo.TabIndex = 8;
            this.chkBDelMinVersionInfo.Text = "Remove Version Limitation";
            this.chkBDelMinVersionInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 397, 201 );
            this.Controls.Add( this.chkBDelMinVersionInfo );
            this.Controls.Add( this.panel1 );
            this.Controls.Add( this.btnGetSln );
            this.Controls.Add( this.btnConvert );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.tbSlnLoc );
            this.Controls.Add( this.cbVersions );
            this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size( 413, 240 );
            this.MinimumSize = new System.Drawing.Size( 413, 240 );
            this.Name = "Form1";
            this.Text = "VS Version Changer by MeowthK";
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVersions;
        private System.Windows.Forms.TextBox tbSlnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnGetSln;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkBDelMinVersionInfo;
    }
}

