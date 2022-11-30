namespace MathematicTests
{
    partial class frmChallenge
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLeftTime = new System.Windows.Forms.Label();
            this.lblFirstNbrAddition = new System.Windows.Forms.Label();
            this.lblFirstNbrMult = new System.Windows.Forms.Label();
            this.lblFirstNbrDiv = new System.Windows.Forms.Label();
            this.lblDiv = new System.Windows.Forms.Label();
            this.lblMult = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblFirstNbrSub = new System.Windows.Forms.Label();
            this.lblSecondNbrSub = new System.Windows.Forms.Label();
            this.lblSecondNbrMult = new System.Windows.Forms.Label();
            this.lblSecondNbrDiv = new System.Windows.Forms.Label();
            this.lblSecondNbrAdition = new System.Windows.Forms.Label();
            this.numericUpDownAdd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSub = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMult = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDiv = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTimeLeft = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEndQuiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLeftTime
            // 
            this.lblLeftTime.AutoSize = true;
            this.lblLeftTime.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeftTime.Location = new System.Drawing.Point(119, 64);
            this.lblLeftTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLeftTime.Name = "lblLeftTime";
            this.lblLeftTime.Size = new System.Drawing.Size(160, 22);
            this.lblLeftTime.TabIndex = 0;
            this.lblLeftTime.Text = "Tempo Restante";
            // 
            // lblFirstNbrAddition
            // 
            this.lblFirstNbrAddition.AutoSize = true;
            this.lblFirstNbrAddition.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstNbrAddition.Location = new System.Drawing.Point(119, 253);
            this.lblFirstNbrAddition.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstNbrAddition.Name = "lblFirstNbrAddition";
            this.lblFirstNbrAddition.Size = new System.Drawing.Size(22, 22);
            this.lblFirstNbrAddition.TabIndex = 1;
            this.lblFirstNbrAddition.Text = "?";
            // 
            // lblFirstNbrMult
            // 
            this.lblFirstNbrMult.AutoSize = true;
            this.lblFirstNbrMult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstNbrMult.Location = new System.Drawing.Point(119, 387);
            this.lblFirstNbrMult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstNbrMult.Name = "lblFirstNbrMult";
            this.lblFirstNbrMult.Size = new System.Drawing.Size(22, 22);
            this.lblFirstNbrMult.TabIndex = 2;
            this.lblFirstNbrMult.Text = "?";
            // 
            // lblFirstNbrDiv
            // 
            this.lblFirstNbrDiv.AutoSize = true;
            this.lblFirstNbrDiv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstNbrDiv.Location = new System.Drawing.Point(119, 456);
            this.lblFirstNbrDiv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstNbrDiv.Name = "lblFirstNbrDiv";
            this.lblFirstNbrDiv.Size = new System.Drawing.Size(22, 22);
            this.lblFirstNbrDiv.TabIndex = 3;
            this.lblFirstNbrDiv.Text = "?";
            // 
            // lblDiv
            // 
            this.lblDiv.AutoSize = true;
            this.lblDiv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiv.Location = new System.Drawing.Point(223, 456);
            this.lblDiv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiv.Name = "lblDiv";
            this.lblDiv.Size = new System.Drawing.Size(20, 22);
            this.lblDiv.TabIndex = 4;
            this.lblDiv.Text = "÷";
            // 
            // lblMult
            // 
            this.lblMult.AutoSize = true;
            this.lblMult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMult.Location = new System.Drawing.Point(222, 387);
            this.lblMult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMult.Name = "lblMult";
            this.lblMult.Size = new System.Drawing.Size(23, 22);
            this.lblMult.TabIndex = 5;
            this.lblMult.Text = "X";
            this.lblMult.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSub.Location = new System.Drawing.Point(225, 318);
            this.lblSub.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(16, 22);
            this.lblSub.TabIndex = 6;
            this.lblSub.Text = "-";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdd.Location = new System.Drawing.Point(223, 253);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(21, 22);
            this.lblAdd.TabIndex = 7;
            this.lblAdd.Text = "+";
            // 
            // lblFirstNbrSub
            // 
            this.lblFirstNbrSub.AutoSize = true;
            this.lblFirstNbrSub.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstNbrSub.Location = new System.Drawing.Point(119, 318);
            this.lblFirstNbrSub.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstNbrSub.Name = "lblFirstNbrSub";
            this.lblFirstNbrSub.Size = new System.Drawing.Size(22, 22);
            this.lblFirstNbrSub.TabIndex = 8;
            this.lblFirstNbrSub.Text = "?";
            // 
            // lblSecondNbrSub
            // 
            this.lblSecondNbrSub.AutoSize = true;
            this.lblSecondNbrSub.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecondNbrSub.Location = new System.Drawing.Point(324, 318);
            this.lblSecondNbrSub.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSecondNbrSub.Name = "lblSecondNbrSub";
            this.lblSecondNbrSub.Size = new System.Drawing.Size(22, 22);
            this.lblSecondNbrSub.TabIndex = 9;
            this.lblSecondNbrSub.Text = "?";
            // 
            // lblSecondNbrMult
            // 
            this.lblSecondNbrMult.AutoSize = true;
            this.lblSecondNbrMult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecondNbrMult.Location = new System.Drawing.Point(324, 387);
            this.lblSecondNbrMult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSecondNbrMult.Name = "lblSecondNbrMult";
            this.lblSecondNbrMult.Size = new System.Drawing.Size(22, 22);
            this.lblSecondNbrMult.TabIndex = 10;
            this.lblSecondNbrMult.Text = "?";
            // 
            // lblSecondNbrDiv
            // 
            this.lblSecondNbrDiv.AutoSize = true;
            this.lblSecondNbrDiv.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecondNbrDiv.Location = new System.Drawing.Point(324, 456);
            this.lblSecondNbrDiv.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSecondNbrDiv.Name = "lblSecondNbrDiv";
            this.lblSecondNbrDiv.Size = new System.Drawing.Size(22, 22);
            this.lblSecondNbrDiv.TabIndex = 11;
            this.lblSecondNbrDiv.Text = "?";
            // 
            // lblSecondNbrAdition
            // 
            this.lblSecondNbrAdition.AutoSize = true;
            this.lblSecondNbrAdition.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecondNbrAdition.Location = new System.Drawing.Point(324, 253);
            this.lblSecondNbrAdition.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSecondNbrAdition.Name = "lblSecondNbrAdition";
            this.lblSecondNbrAdition.Size = new System.Drawing.Size(22, 22);
            this.lblSecondNbrAdition.TabIndex = 12;
            this.lblSecondNbrAdition.Text = "?";
            // 
            // numericUpDownAdd
            // 
            this.numericUpDownAdd.Location = new System.Drawing.Point(482, 248);
            this.numericUpDownAdd.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownAdd.Name = "numericUpDownAdd";
            this.numericUpDownAdd.Size = new System.Drawing.Size(189, 32);
            this.numericUpDownAdd.TabIndex = 1;
            // 
            // numericUpDownSub
            // 
            this.numericUpDownSub.Location = new System.Drawing.Point(482, 315);
            this.numericUpDownSub.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownSub.Name = "numericUpDownSub";
            this.numericUpDownSub.Size = new System.Drawing.Size(189, 32);
            this.numericUpDownSub.TabIndex = 2;
            // 
            // numericUpDownMult
            // 
            this.numericUpDownMult.Location = new System.Drawing.Point(482, 382);
            this.numericUpDownMult.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownMult.Name = "numericUpDownMult";
            this.numericUpDownMult.Size = new System.Drawing.Size(189, 32);
            this.numericUpDownMult.TabIndex = 3;
            // 
            // numericUpDownDiv
            // 
            this.numericUpDownDiv.Location = new System.Drawing.Point(482, 451);
            this.numericUpDownDiv.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownDiv.Name = "numericUpDownDiv";
            this.numericUpDownDiv.Size = new System.Drawing.Size(189, 32);
            this.numericUpDownDiv.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(413, 320);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 22);
            this.label14.TabIndex = 17;
            this.label14.Text = "=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(413, 387);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 22);
            this.label15.TabIndex = 18;
            this.label15.Text = "=";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(413, 456);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 22);
            this.label16.TabIndex = 19;
            this.label16.Text = "=";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(413, 253);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 22);
            this.label17.TabIndex = 20;
            this.label17.Text = "=";
            // 
            // txtTimeLeft
            // 
            this.txtTimeLeft.Location = new System.Drawing.Point(413, 59);
            this.txtTimeLeft.Name = "txtTimeLeft";
            this.txtTimeLeft.ReadOnly = true;
            this.txtTimeLeft.Size = new System.Drawing.Size(258, 32);
            this.txtTimeLeft.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(222, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 36);
            this.button1.TabIndex = 22;
            this.button1.Text = "Iniciar o quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEndQuiz
            // 
            this.btnEndQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndQuiz.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEndQuiz.ForeColor = System.Drawing.Color.Red;
            this.btnEndQuiz.Location = new System.Drawing.Point(413, 554);
            this.btnEndQuiz.Name = "btnEndQuiz";
            this.btnEndQuiz.Size = new System.Drawing.Size(143, 36);
            this.btnEndQuiz.TabIndex = 23;
            this.btnEndQuiz.Text = "Finalizar";
            this.btnEndQuiz.UseVisualStyleBackColor = true;
            this.btnEndQuiz.Visible = false;
            // 
            // frmChallenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(761, 602);
            this.Controls.Add(this.btnEndQuiz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTimeLeft);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDownDiv);
            this.Controls.Add(this.numericUpDownMult);
            this.Controls.Add(this.numericUpDownSub);
            this.Controls.Add(this.numericUpDownAdd);
            this.Controls.Add(this.lblSecondNbrAdition);
            this.Controls.Add(this.lblSecondNbrDiv);
            this.Controls.Add(this.lblSecondNbrMult);
            this.Controls.Add(this.lblSecondNbrSub);
            this.Controls.Add(this.lblFirstNbrSub);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblMult);
            this.Controls.Add(this.lblDiv);
            this.Controls.Add(this.lblFirstNbrDiv);
            this.Controls.Add(this.lblFirstNbrMult);
            this.Controls.Add(this.lblFirstNbrAddition);
            this.Controls.Add(this.lblLeftTime);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmChallenge";
            this.Text = "Testes de Matematica";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLeftTime;
        private Label lblFirstNbrAddition;
        private Label lblFirstNbrMult;
        private Label lblFirstNbrDiv;
        private Label lblDiv;
        private Label lblMult;
        private Label lblSub;
        private Label lblAdd;
        private Label lblFirstNbrSub;
        private Label lblSecondNbrSub;
        private Label lblSecondNbrMult;
        private Label lblSecondNbrDiv;
        private Label lblSecondNbrAdition;
        private NumericUpDown numericUpDownAdd;
        private NumericUpDown numericUpDownSub;
        private NumericUpDown numericUpDownMult;
        private NumericUpDown numericUpDownDiv;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtTimeLeft;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button btnEndQuiz;
    }
}