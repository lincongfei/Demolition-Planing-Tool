﻿namespace Demolition_Planing_Tool
{
    partial class IntroForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuildingNameBox = new System.Windows.Forms.TextBox();
            this.NumberFloorBox = new System.Windows.Forms.TextBox();
            this.NumberRoomPerFloorBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Floors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. rooms per floor";
            // 
            // BuildingNameBox
            // 
            this.BuildingNameBox.Location = new System.Drawing.Point(392, 86);
            this.BuildingNameBox.Name = "BuildingNameBox";
            this.BuildingNameBox.Size = new System.Drawing.Size(100, 20);
            this.BuildingNameBox.TabIndex = 3;
            // 
            // NumberFloorBox
            // 
            this.NumberFloorBox.Location = new System.Drawing.Point(392, 140);
            this.NumberFloorBox.Name = "NumberFloorBox";
            this.NumberFloorBox.Size = new System.Drawing.Size(100, 20);
            this.NumberFloorBox.TabIndex = 4;
            this.NumberFloorBox.Text = "0";
            // 
            // NumberRoomPerFloorBox
            // 
            this.NumberRoomPerFloorBox.Location = new System.Drawing.Point(392, 202);
            this.NumberRoomPerFloorBox.Name = "NumberRoomPerFloorBox";
            this.NumberRoomPerFloorBox.Size = new System.Drawing.Size(100, 20);
            this.NumberRoomPerFloorBox.TabIndex = 5;
            this.NumberRoomPerFloorBox.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Planning";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Load Plan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumberRoomPerFloorBox);
            this.Controls.Add(this.NumberFloorBox);
            this.Controls.Add(this.BuildingNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IntroForm";
            this.Text = "Demolition Planning Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BuildingNameBox;
        private System.Windows.Forms.TextBox NumberFloorBox;
        private System.Windows.Forms.TextBox NumberRoomPerFloorBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}