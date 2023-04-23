
namespace WindowsFormsApp1
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.prbStorage = new CircularProgressBar.CircularProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.prbRAM = new CircularProgressBar.CircularProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.prbCPU = new CircularProgressBar.CircularProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(12, 278);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(484, 187);
            this.panel8.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Reminder";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.prbStorage);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(521, 157);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 308);
            this.panel7.TabIndex = 5;
            // 
            // prbStorage
            // 
            this.prbStorage.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("prbStorage.AnimationFunction")));
            this.prbStorage.AnimationSpeed = 500;
            this.prbStorage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.prbStorage.Font = new System.Drawing.Font("Bahnschrift SemiBold", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prbStorage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.prbStorage.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.prbStorage.InnerMargin = 2;
            this.prbStorage.InnerWidth = -1;
            this.prbStorage.Location = new System.Drawing.Point(28, 63);
            this.prbStorage.MarqueeAnimationSpeed = 2000;
            this.prbStorage.Name = "prbStorage";
            this.prbStorage.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.prbStorage.OuterMargin = -25;
            this.prbStorage.OuterWidth = 26;
            this.prbStorage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.prbStorage.ProgressWidth = 6;
            this.prbStorage.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.prbStorage.Size = new System.Drawing.Size(143, 139);
            this.prbStorage.StartAngle = 270;
            this.prbStorage.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbStorage.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.prbStorage.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.prbStorage.SubscriptText = "";
            this.prbStorage.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.prbStorage.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.prbStorage.SuperscriptText = "";
            this.prbStorage.TabIndex = 1;
            this.prbStorage.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.prbStorage.Value = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "GPU";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(521, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 123);
            this.panel9.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Time";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.prbRAM);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(248, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 238);
            this.panel5.TabIndex = 8;
            // 
            // prbRAM
            // 
            this.prbRAM.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("prbRAM.AnimationFunction")));
            this.prbRAM.AnimationSpeed = 500;
            this.prbRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.prbRAM.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.prbRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.prbRAM.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.prbRAM.InnerMargin = 2;
            this.prbRAM.InnerWidth = -1;
            this.prbRAM.Location = new System.Drawing.Point(48, 54);
            this.prbRAM.MarqueeAnimationSpeed = 2000;
            this.prbRAM.Name = "prbRAM";
            this.prbRAM.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.prbRAM.OuterMargin = -25;
            this.prbRAM.OuterWidth = 26;
            this.prbRAM.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.prbRAM.ProgressWidth = 6;
            this.prbRAM.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.prbRAM.Size = new System.Drawing.Size(143, 139);
            this.prbRAM.StartAngle = 270;
            this.prbRAM.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbRAM.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.prbRAM.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.prbRAM.SubscriptText = "";
            this.prbRAM.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.prbRAM.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.prbRAM.SuperscriptText = "";
            this.prbRAM.TabIndex = 1;
            this.prbRAM.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.prbRAM.Value = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Memory";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.prbCPU);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 238);
            this.panel4.TabIndex = 9;
            // 
            // prbCPU
            // 
            this.prbCPU.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("prbCPU.AnimationFunction")));
            this.prbCPU.AnimationSpeed = 500;
            this.prbCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.prbCPU.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.prbCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.prbCPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.prbCPU.InnerMargin = 2;
            this.prbCPU.InnerWidth = -1;
            this.prbCPU.Location = new System.Drawing.Point(30, 54);
            this.prbCPU.MarqueeAnimationSpeed = 2000;
            this.prbCPU.Name = "prbCPU";
            this.prbCPU.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.prbCPU.OuterMargin = -25;
            this.prbCPU.OuterWidth = 26;
            this.prbCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.prbCPU.ProgressWidth = 6;
            this.prbCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.prbCPU.Size = new System.Drawing.Size(143, 139);
            this.prbCPU.StartAngle = 270;
            this.prbCPU.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbCPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.prbCPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.prbCPU.SubscriptText = "";
            this.prbCPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.prbCPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.prbCPU.SuperscriptText = "";
            this.prbCPU.TabIndex = 1;
            this.prbCPU.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.prbCPU.Value = 68;
            this.prbCPU.Click += new System.EventHandler(this.ProgressBar1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPU";
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processzor";
            this.CPU.CounterName = "A processzor kihasználtsága (%)";
            this.CPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memória";
            this.RAM.CounterName = "Rendelkezésre álló memória (megabájt)";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar prbCPU;
        private CircularProgressBar.CircularProgressBar prbStorage;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar prbRAM;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter RAM;
    }
}