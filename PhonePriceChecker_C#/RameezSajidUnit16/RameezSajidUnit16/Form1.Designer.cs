namespace RameezSajidUnit16
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
            this.buttonStore = new System.Windows.Forms.Button();
            this.listBoxMobileData = new System.Windows.Forms.ListBox();
            this.textBoxMobileName = new System.Windows.Forms.TextBox();
            this.buttonMostExpensive = new System.Windows.Forms.Button();
            this.buttonCheapest = new System.Windows.Forms.Button();
            this.textBoxMostExpensive = new System.Windows.Forms.TextBox();
            this.textBoxCheapest = new System.Windows.Forms.TextBox();
            this.textBoxMobilePrice = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStore
            // 
            this.buttonStore.Location = new System.Drawing.Point(77, 331);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(75, 23);
            this.buttonStore.TabIndex = 1;
            this.buttonStore.Text = "Store";
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // listBoxMobileData
            // 
            this.listBoxMobileData.FormattingEnabled = true;
            this.listBoxMobileData.Location = new System.Drawing.Point(77, 150);
            this.listBoxMobileData.Name = "listBoxMobileData";
            this.listBoxMobileData.Size = new System.Drawing.Size(148, 121);
            this.listBoxMobileData.TabIndex = 2;
            // 
            // textBoxMobileName
            // 
            this.textBoxMobileName.Location = new System.Drawing.Point(77, 294);
            this.textBoxMobileName.Name = "textBoxMobileName";
            this.textBoxMobileName.Size = new System.Drawing.Size(148, 20);
            this.textBoxMobileName.TabIndex = 3;
            // 
            // buttonMostExpensive
            // 
            this.buttonMostExpensive.Location = new System.Drawing.Point(77, 29);
            this.buttonMostExpensive.Name = "buttonMostExpensive";
            this.buttonMostExpensive.Size = new System.Drawing.Size(100, 23);
            this.buttonMostExpensive.TabIndex = 4;
            this.buttonMostExpensive.Text = "Most Expensive";
            this.buttonMostExpensive.UseVisualStyleBackColor = true;
            this.buttonMostExpensive.Click += new System.EventHandler(this.buttonMostExpensive_Click);
            // 
            // buttonCheapest
            // 
            this.buttonCheapest.Location = new System.Drawing.Point(301, 29);
            this.buttonCheapest.Name = "buttonCheapest";
            this.buttonCheapest.Size = new System.Drawing.Size(75, 23);
            this.buttonCheapest.TabIndex = 5;
            this.buttonCheapest.Text = "Cheapest";
            this.buttonCheapest.UseVisualStyleBackColor = true;
            this.buttonCheapest.Click += new System.EventHandler(this.buttonCheapest_Click);
            // 
            // textBoxMostExpensive
            // 
            this.textBoxMostExpensive.Location = new System.Drawing.Point(77, 83);
            this.textBoxMostExpensive.Name = "textBoxMostExpensive";
            this.textBoxMostExpensive.Size = new System.Drawing.Size(414, 20);
            this.textBoxMostExpensive.TabIndex = 6;
            // 
            // textBoxCheapest
            // 
            this.textBoxCheapest.Location = new System.Drawing.Point(77, 109);
            this.textBoxCheapest.Name = "textBoxCheapest";
            this.textBoxCheapest.Size = new System.Drawing.Size(414, 20);
            this.textBoxCheapest.TabIndex = 7;
            // 
            // textBoxMobilePrice
            // 
            this.textBoxMobilePrice.Location = new System.Drawing.Point(301, 294);
            this.textBoxMobilePrice.Name = "textBoxMobilePrice";
            this.textBoxMobilePrice.Size = new System.Drawing.Size(157, 20);
            this.textBoxMobilePrice.TabIndex = 8;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(301, 331);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 9;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 462);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxMobilePrice);
            this.Controls.Add(this.textBoxCheapest);
            this.Controls.Add(this.textBoxMostExpensive);
            this.Controls.Add(this.buttonCheapest);
            this.Controls.Add(this.buttonMostExpensive);
            this.Controls.Add(this.textBoxMobileName);
            this.Controls.Add(this.listBoxMobileData);
            this.Controls.Add(this.buttonStore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.ListBox listBoxMobileData;
        private System.Windows.Forms.TextBox textBoxMobileName;
        private System.Windows.Forms.Button buttonMostExpensive;
        private System.Windows.Forms.Button buttonCheapest;
        private System.Windows.Forms.TextBox textBoxMostExpensive;
        private System.Windows.Forms.TextBox textBoxCheapest;
        private System.Windows.Forms.TextBox textBoxMobilePrice;
        private System.Windows.Forms.Button buttonHelp;
    }
}

