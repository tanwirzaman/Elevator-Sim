namespace ElevatorSim
{
    partial class ElevatorSimForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnElev5 = new System.Windows.Forms.Button();
            this.btnElev4 = new System.Windows.Forms.Button();
            this.btnElev3 = new System.Windows.Forms.Button();
            this.btnElev2 = new System.Windows.Forms.Button();
            this.btnElev1 = new System.Windows.Forms.Button();
            this.lblElevStatus = new System.Windows.Forms.Label();
            this.lblElevCurrFloor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOut1up = new System.Windows.Forms.Button();
            this.btnOut2down = new System.Windows.Forms.Button();
            this.btnOut4up = new System.Windows.Forms.Button();
            this.btnOut4down = new System.Windows.Forms.Button();
            this.btnOut3up = new System.Windows.Forms.Button();
            this.btnOut3down = new System.Windows.Forms.Button();
            this.btnOut2up = new System.Windows.Forms.Button();
            this.btnOut5down = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnElev5);
            this.panel1.Controls.Add(this.btnElev4);
            this.panel1.Controls.Add(this.btnElev3);
            this.panel1.Controls.Add(this.btnElev2);
            this.panel1.Controls.Add(this.btnElev1);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 282);
            this.panel1.TabIndex = 0;
            // 
            // btnElev5
            // 
            this.btnElev5.Location = new System.Drawing.Point(165, 52);
            this.btnElev5.Name = "btnElev5";
            this.btnElev5.Size = new System.Drawing.Size(75, 23);
            this.btnElev5.TabIndex = 4;
            this.btnElev5.Text = "5";
            this.btnElev5.UseVisualStyleBackColor = true;
            this.btnElev5.Click += new System.EventHandler(this.btnElev5_Click);
            // 
            // btnElev4
            // 
            this.btnElev4.Location = new System.Drawing.Point(165, 93);
            this.btnElev4.Name = "btnElev4";
            this.btnElev4.Size = new System.Drawing.Size(75, 23);
            this.btnElev4.TabIndex = 3;
            this.btnElev4.Text = "4";
            this.btnElev4.UseVisualStyleBackColor = true;
            this.btnElev4.Click += new System.EventHandler(this.btnElev4_Click);
            // 
            // btnElev3
            // 
            this.btnElev3.Location = new System.Drawing.Point(166, 128);
            this.btnElev3.Name = "btnElev3";
            this.btnElev3.Size = new System.Drawing.Size(75, 23);
            this.btnElev3.TabIndex = 2;
            this.btnElev3.Text = "3";
            this.btnElev3.UseVisualStyleBackColor = true;
            this.btnElev3.Click += new System.EventHandler(this.btnElev3_Click);
            // 
            // btnElev2
            // 
            this.btnElev2.Location = new System.Drawing.Point(166, 168);
            this.btnElev2.Name = "btnElev2";
            this.btnElev2.Size = new System.Drawing.Size(75, 23);
            this.btnElev2.TabIndex = 1;
            this.btnElev2.Text = "2";
            this.btnElev2.UseVisualStyleBackColor = true;
            this.btnElev2.Click += new System.EventHandler(this.btnElev2_Click);
            // 
            // btnElev1
            // 
            this.btnElev1.Location = new System.Drawing.Point(166, 212);
            this.btnElev1.Name = "btnElev1";
            this.btnElev1.Size = new System.Drawing.Size(75, 23);
            this.btnElev1.TabIndex = 0;
            this.btnElev1.Text = "1";
            this.btnElev1.UseVisualStyleBackColor = true;
            this.btnElev1.Click += new System.EventHandler(this.btnElev1_Click);
            // 
            // lblElevStatus
            // 
            this.lblElevStatus.AutoSize = true;
            this.lblElevStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevStatus.Location = new System.Drawing.Point(30, 43);
            this.lblElevStatus.Name = "lblElevStatus";
            this.lblElevStatus.Size = new System.Drawing.Size(48, 17);
            this.lblElevStatus.TabIndex = 7;
            this.lblElevStatus.Text = "Status";
            // 
            // lblElevCurrFloor
            // 
            this.lblElevCurrFloor.AutoSize = true;
            this.lblElevCurrFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevCurrFloor.Location = new System.Drawing.Point(198, 43);
            this.lblElevCurrFloor.Name = "lblElevCurrFloor";
            this.lblElevCurrFloor.Size = new System.Drawing.Size(36, 17);
            this.lblElevCurrFloor.TabIndex = 6;
            this.lblElevCurrFloor.Text = "floor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Current Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inside Elevator";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnOut1up);
            this.panel2.Controls.Add(this.btnOut2down);
            this.panel2.Controls.Add(this.btnOut4up);
            this.panel2.Controls.Add(this.btnOut4down);
            this.panel2.Controls.Add(this.btnOut3up);
            this.panel2.Controls.Add(this.btnOut3down);
            this.panel2.Controls.Add(this.btnOut2up);
            this.panel2.Controls.Add(this.btnOut5down);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(453, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 282);
            this.panel2.TabIndex = 1;
            // 
            // btnOut1up
            // 
            this.btnOut1up.Location = new System.Drawing.Point(196, 217);
            this.btnOut1up.Name = "btnOut1up";
            this.btnOut1up.Size = new System.Drawing.Size(75, 23);
            this.btnOut1up.TabIndex = 17;
            this.btnOut1up.Text = "UP";
            this.btnOut1up.UseVisualStyleBackColor = true;
            this.btnOut1up.Click += new System.EventHandler(this.btnOut1up_Click);
            // 
            // btnOut2down
            // 
            this.btnOut2down.Location = new System.Drawing.Point(277, 173);
            this.btnOut2down.Name = "btnOut2down";
            this.btnOut2down.Size = new System.Drawing.Size(75, 23);
            this.btnOut2down.TabIndex = 16;
            this.btnOut2down.Text = "DOWN";
            this.btnOut2down.UseVisualStyleBackColor = true;
            this.btnOut2down.Click += new System.EventHandler(this.btnOut2down_Click);
            // 
            // btnOut4up
            // 
            this.btnOut4up.Location = new System.Drawing.Point(196, 98);
            this.btnOut4up.Name = "btnOut4up";
            this.btnOut4up.Size = new System.Drawing.Size(75, 23);
            this.btnOut4up.TabIndex = 15;
            this.btnOut4up.Text = "UP";
            this.btnOut4up.UseVisualStyleBackColor = true;
            this.btnOut4up.Click += new System.EventHandler(this.btnOut4up_Click);
            // 
            // btnOut4down
            // 
            this.btnOut4down.Location = new System.Drawing.Point(277, 98);
            this.btnOut4down.Name = "btnOut4down";
            this.btnOut4down.Size = new System.Drawing.Size(75, 23);
            this.btnOut4down.TabIndex = 14;
            this.btnOut4down.Text = "DOWN";
            this.btnOut4down.UseVisualStyleBackColor = true;
            this.btnOut4down.Click += new System.EventHandler(this.btnOut4down_Click);
            // 
            // btnOut3up
            // 
            this.btnOut3up.Location = new System.Drawing.Point(196, 138);
            this.btnOut3up.Name = "btnOut3up";
            this.btnOut3up.Size = new System.Drawing.Size(75, 23);
            this.btnOut3up.TabIndex = 13;
            this.btnOut3up.Text = "UP";
            this.btnOut3up.UseVisualStyleBackColor = true;
            this.btnOut3up.Click += new System.EventHandler(this.btnOut3up_Click);
            // 
            // btnOut3down
            // 
            this.btnOut3down.Location = new System.Drawing.Point(277, 138);
            this.btnOut3down.Name = "btnOut3down";
            this.btnOut3down.Size = new System.Drawing.Size(75, 23);
            this.btnOut3down.TabIndex = 12;
            this.btnOut3down.Text = "DOWN";
            this.btnOut3down.UseVisualStyleBackColor = true;
            this.btnOut3down.Click += new System.EventHandler(this.btnOut3down_Click);
            // 
            // btnOut2up
            // 
            this.btnOut2up.Location = new System.Drawing.Point(196, 173);
            this.btnOut2up.Name = "btnOut2up";
            this.btnOut2up.Size = new System.Drawing.Size(75, 23);
            this.btnOut2up.TabIndex = 11;
            this.btnOut2up.Text = "UP";
            this.btnOut2up.UseVisualStyleBackColor = true;
            this.btnOut2up.Click += new System.EventHandler(this.btnOut2up_Click);
            // 
            // btnOut5down
            // 
            this.btnOut5down.Location = new System.Drawing.Point(196, 47);
            this.btnOut5down.Name = "btnOut5down";
            this.btnOut5down.Size = new System.Drawing.Size(75, 23);
            this.btnOut5down.TabIndex = 10;
            this.btnOut5down.Text = "DOWN";
            this.btnOut5down.UseVisualStyleBackColor = true;
            this.btnOut5down.Click += new System.EventHandler(this.btnOut5down_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Floor 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Floor 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Floor 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Floor 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Floor 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Outside Elevator";
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblElevStatus);
            this.panel3.Controls.Add(this.lblElevCurrFloor);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(299, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 81);
            this.panel3.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(469, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "prim";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(401, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Next :";
            // 
            // ElevatorSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(909, 445);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ElevatorSimForm";
            this.Text = "Elevator Sim";
            this.Load += new System.EventHandler(this.ElevatorSimForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnElev5;
        private System.Windows.Forms.Button btnElev4;
        private System.Windows.Forms.Button btnElev3;
        private System.Windows.Forms.Button btnElev2;
        private System.Windows.Forms.Button btnElev1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblElevStatus;
        private System.Windows.Forms.Label lblElevCurrFloor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOut1up;
        private System.Windows.Forms.Button btnOut2down;
        private System.Windows.Forms.Button btnOut4up;
        private System.Windows.Forms.Button btnOut4down;
        private System.Windows.Forms.Button btnOut3up;
        private System.Windows.Forms.Button btnOut3down;
        private System.Windows.Forms.Button btnOut2up;
        private System.Windows.Forms.Button btnOut5down;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
       
    }
}

