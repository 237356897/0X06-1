namespace Vision_Assistant
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
            this.imageViewer = new NationalInstruments.Vision.WindowsForms.ImageViewer();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numBlueMax = new System.Windows.Forms.NumericUpDown();
            this.numGreenMax = new System.Windows.Forms.NumericUpDown();
            this.numRedMax = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outsideVal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numinside = new System.Windows.Forms.NumericUpDown();
            this.insideVal = new System.Windows.Forms.Label();
            this.numoutside = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numinside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numoutside)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageViewer
            // 
            this.imageViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.imageViewer, "imageViewer");
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.ZoomToFit = true;
            // 
            // LoadImageButton
            // 
            resources.ApplyResources(this.LoadImageButton, "LoadImageButton");
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // RunButton
            // 
            resources.ApplyResources(this.RunButton, "RunButton");
            this.RunButton.Name = "RunButton";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numBlueMax);
            this.groupBox1.Controls.Add(this.numGreenMax);
            this.groupBox1.Controls.Add(this.numRedMax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.outsideVal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CheckResult);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numinside);
            this.groupBox1.Controls.Add(this.ExitButton);
            this.groupBox1.Controls.Add(this.insideVal);
            this.groupBox1.Controls.Add(this.LoadImageButton);
            this.groupBox1.Controls.Add(this.RunButton);
            this.groupBox1.Controls.Add(this.numoutside);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "3";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // numBlueMax
            // 
            resources.ApplyResources(this.numBlueMax, "numBlueMax");
            this.numBlueMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numBlueMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBlueMax.Name = "numBlueMax";
            this.numBlueMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numGreenMax
            // 
            resources.ApplyResources(this.numGreenMax, "numGreenMax");
            this.numGreenMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGreenMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGreenMax.Name = "numGreenMax";
            this.numGreenMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numRedMax
            // 
            resources.ApplyResources(this.numRedMax, "numRedMax");
            this.numRedMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numRedMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRedMax.Name = "numRedMax";
            this.numRedMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // outsideVal
            // 
            resources.ApplyResources(this.outsideVal, "outsideVal");
            this.outsideVal.Name = "outsideVal";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CheckResult
            // 
            this.CheckResult.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.CheckResult, "CheckResult");
            this.CheckResult.Name = "CheckResult";
            this.CheckResult.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numinside
            // 
            resources.ApplyResources(this.numinside, "numinside");
            this.numinside.Name = "numinside";
            // 
            // insideVal
            // 
            resources.ApplyResources(this.insideVal, "insideVal");
            this.insideVal.Name = "insideVal";
            // 
            // numoutside
            // 
            resources.ApplyResources(this.numoutside, "numoutside");
            this.numoutside.Name = "numoutside";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imageViewer);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBlueMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGreenMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRedMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numinside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numoutside)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NationalInstruments.Vision.WindowsForms.ImageViewer imageViewer;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CheckResult;
        private System.Windows.Forms.NumericUpDown numinside;
        private System.Windows.Forms.NumericUpDown numoutside;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outsideVal;
        private System.Windows.Forms.Label insideVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numGreenMax;
        private System.Windows.Forms.NumericUpDown numRedMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numBlueMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

