namespace RandomTests
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtNumbersList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtList1 = new System.Windows.Forms.TextBox();
            this.txtList2 = new System.Windows.Forms.TextBox();
            this.lstCombinedLists = new System.Windows.Forms.ListBox();
            this.btnListCombine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFibonacciResult = new System.Windows.Forms.TextBox();
            this.txtNumbersToRearrange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRearrange = new System.Windows.Forms.Button();
            this.btnFB = new System.Windows.Forms.Button();
            this.lblFB = new System.Windows.Forms.Label();
            this.lstFB = new System.Windows.Forms.ListBox();
            this.lstFBmod = new System.Windows.Forms.ListBox();
            this.btnFBmod = new System.Windows.Forms.Button();
            this.txtRearranged = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(344, 29);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 0;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(222, 25);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(92, 23);
            this.btnCompute.TabIndex = 1;
            this.btnCompute.Text = "Add Numbers";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtNumbersList
            // 
            this.txtNumbersList.Location = new System.Drawing.Point(52, 29);
            this.txtNumbersList.Name = "txtNumbersList";
            this.txtNumbersList.Size = new System.Drawing.Size(100, 20);
            this.txtNumbersList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write list of numbers separated by a comma";
            // 
            // txtList1
            // 
            this.txtList1.Location = new System.Drawing.Point(52, 92);
            this.txtList1.Name = "txtList1";
            this.txtList1.Size = new System.Drawing.Size(100, 20);
            this.txtList1.TabIndex = 4;
            // 
            // txtList2
            // 
            this.txtList2.Location = new System.Drawing.Point(52, 167);
            this.txtList2.Name = "txtList2";
            this.txtList2.Size = new System.Drawing.Size(100, 20);
            this.txtList2.TabIndex = 5;
            // 
            // lstCombinedLists
            // 
            this.lstCombinedLists.FormattingEnabled = true;
            this.lstCombinedLists.Location = new System.Drawing.Point(315, 92);
            this.lstCombinedLists.Name = "lstCombinedLists";
            this.lstCombinedLists.Size = new System.Drawing.Size(120, 95);
            this.lstCombinedLists.TabIndex = 6;
            // 
            // btnListCombine
            // 
            this.btnListCombine.Location = new System.Drawing.Point(190, 106);
            this.btnListCombine.Name = "btnListCombine";
            this.btnListCombine.Size = new System.Drawing.Size(72, 36);
            this.btnListCombine.TabIndex = 7;
            this.btnListCombine.Text = "Combine Lists";
            this.btnListCombine.UseVisualStyleBackColor = true;
            this.btnListCombine.Click += new System.EventHandler(this.btnListCombine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Write two lists of words or numbers separated by commas";
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Location = new System.Drawing.Point(190, 205);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(75, 23);
            this.btnFibonacci.TabIndex = 9;
            this.btnFibonacci.Text = "Calculate";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Compute Fibonacci to 20 places";
            // 
            // txtFibonacciResult
            // 
            this.txtFibonacciResult.Location = new System.Drawing.Point(12, 234);
            this.txtFibonacciResult.Name = "txtFibonacciResult";
            this.txtFibonacciResult.Size = new System.Drawing.Size(476, 20);
            this.txtFibonacciResult.TabIndex = 12;
            // 
            // txtNumbersToRearrange
            // 
            this.txtNumbersToRearrange.Location = new System.Drawing.Point(12, 305);
            this.txtNumbersToRearrange.Name = "txtNumbersToRearrange";
            this.txtNumbersToRearrange.Size = new System.Drawing.Size(162, 20);
            this.txtNumbersToRearrange.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Write positive numbers separated by a comma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Rearranged into highest integer";
            // 
            // btnRearrange
            // 
            this.btnRearrange.Location = new System.Drawing.Point(214, 305);
            this.btnRearrange.Name = "btnRearrange";
            this.btnRearrange.Size = new System.Drawing.Size(75, 23);
            this.btnRearrange.TabIndex = 17;
            this.btnRearrange.Text = "Go!";
            this.btnRearrange.UseVisualStyleBackColor = true;
            this.btnRearrange.Click += new System.EventHandler(this.btnRearrange_Click);
            // 
            // btnFB
            // 
            this.btnFB.Location = new System.Drawing.Point(19, 363);
            this.btnFB.Name = "btnFB";
            this.btnFB.Size = new System.Drawing.Size(104, 23);
            this.btnFB.TabIndex = 18;
            this.btnFB.Text = "1,2,3,FizzBuzz!";
            this.btnFB.UseVisualStyleBackColor = true;
            this.btnFB.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFB
            // 
            this.lblFB.AutoSize = true;
            this.lblFB.Location = new System.Drawing.Point(31, 347);
            this.lblFB.Name = "lblFB";
            this.lblFB.Size = new System.Drawing.Size(48, 13);
            this.lblFB.TabIndex = 21;
            this.lblFB.Text = "FizzBuzz";
            // 
            // lstFB
            // 
            this.lstFB.FormattingEnabled = true;
            this.lstFB.Location = new System.Drawing.Point(190, 354);
            this.lstFB.Name = "lstFB";
            this.lstFB.Size = new System.Drawing.Size(120, 43);
            this.lstFB.TabIndex = 22;
            // 
            // lstFBmod
            // 
            this.lstFBmod.FormattingEnabled = true;
            this.lstFBmod.Location = new System.Drawing.Point(190, 404);
            this.lstFBmod.Name = "lstFBmod";
            this.lstFBmod.Size = new System.Drawing.Size(270, 95);
            this.lstFBmod.TabIndex = 23;
            // 
            // btnFBmod
            // 
            this.btnFBmod.Location = new System.Drawing.Point(16, 404);
            this.btnFBmod.Name = "btnFBmod";
            this.btnFBmod.Size = new System.Drawing.Size(107, 23);
            this.btnFBmod.TabIndex = 24;
            this.btnFBmod.Text = "fizz...buzz?";
            this.btnFBmod.UseVisualStyleBackColor = true;
            this.btnFBmod.Click += new System.EventHandler(this.btnFBmod_Click);
            // 
            // txtRearranged
            // 
            this.txtRearranged.Location = new System.Drawing.Point(318, 307);
            this.txtRearranged.Name = "txtRearranged";
            this.txtRearranged.Size = new System.Drawing.Size(100, 20);
            this.txtRearranged.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 614);
            this.Controls.Add(this.txtRearranged);
            this.Controls.Add(this.btnFBmod);
            this.Controls.Add(this.lstFBmod);
            this.Controls.Add(this.lstFB);
            this.Controls.Add(this.lblFB);
            this.Controls.Add(this.btnFB);
            this.Controls.Add(this.btnRearrange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumbersToRearrange);
            this.Controls.Add(this.txtFibonacciResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListCombine);
            this.Controls.Add(this.lstCombinedLists);
            this.Controls.Add(this.txtList2);
            this.Controls.Add(this.txtList1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumbersList);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.lblTotal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtNumbersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtList1;
        private System.Windows.Forms.TextBox txtList2;
        private System.Windows.Forms.ListBox lstCombinedLists;
        private System.Windows.Forms.Button btnListCombine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFibonacciResult;
        private System.Windows.Forms.TextBox txtNumbersToRearrange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRearrange;
        private System.Windows.Forms.Button btnFB;
        private System.Windows.Forms.Label lblFB;
        private System.Windows.Forms.ListBox lstFB;
        private System.Windows.Forms.ListBox lstFBmod;
        private System.Windows.Forms.Button btnFBmod;
        private System.Windows.Forms.TextBox txtRearranged;
    }
}

