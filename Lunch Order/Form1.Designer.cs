
namespace Lunch_Order
{
    partial class Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalad = new System.Windows.Forms.RadioButton();
            this.btnPizza = new System.Windows.Forms.RadioButton();
            this.btnHamburger = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FFbtn = new System.Windows.Forms.CheckBox();
            this.KMMbtn = new System.Windows.Forms.CheckBox();
            this.LTObtn = new System.Windows.Forms.CheckBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalad);
            this.groupBox1.Controls.Add(this.btnPizza);
            this.groupBox1.Controls.Add(this.btnHamburger);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Course";
            // 
            // btnSalad
            // 
            this.btnSalad.AutoSize = true;
            this.btnSalad.Location = new System.Drawing.Point(15, 66);
            this.btnSalad.Name = "btnSalad";
            this.btnSalad.Size = new System.Drawing.Size(91, 19);
            this.btnSalad.TabIndex = 2;
            this.btnSalad.TabStop = true;
            this.btnSalad.Text = "Salad - $4.95";
            this.btnSalad.UseVisualStyleBackColor = true;
            this.btnSalad.CheckedChanged += new System.EventHandler(this.btnSalad_CheckedChanged);
            // 
            // btnPizza
            // 
            this.btnPizza.AutoSize = true;
            this.btnPizza.Location = new System.Drawing.Point(15, 41);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(89, 19);
            this.btnPizza.TabIndex = 1;
            this.btnPizza.TabStop = true;
            this.btnPizza.Text = "Pizza - $5.95";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.CheckedChanged += new System.EventHandler(this.btnPizza_CheckedChanged);
            // 
            // btnHamburger
            // 
            this.btnHamburger.AutoSize = true;
            this.btnHamburger.Location = new System.Drawing.Point(15, 16);
            this.btnHamburger.Name = "btnHamburger";
            this.btnHamburger.Size = new System.Drawing.Size(124, 19);
            this.btnHamburger.TabIndex = 0;
            this.btnHamburger.TabStop = true;
            this.btnHamburger.Text = "Hamburger - $6.95";
            this.btnHamburger.UseVisualStyleBackColor = true;
            this.btnHamburger.CheckedChanged += new System.EventHandler(this.btnHamburger_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOrderTotal);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.txtTax);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(27, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(109, 90);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 23);
            this.txtOrderTotal.TabIndex = 5;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(109, 27);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 4;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(109, 56);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 23);
            this.txtTax.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FFbtn);
            this.groupBox3.Controls.Add(this.KMMbtn);
            this.groupBox3.Controls.Add(this.LTObtn);
            this.groupBox3.Location = new System.Drawing.Point(381, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(205, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add-on Items $0.75/each";
            // 
            // FFbtn
            // 
            this.FFbtn.AutoSize = true;
            this.FFbtn.Location = new System.Drawing.Point(6, 75);
            this.FFbtn.Name = "FFbtn";
            this.FFbtn.Size = new System.Drawing.Size(87, 19);
            this.FFbtn.TabIndex = 2;
            this.FFbtn.Text = "French fries";
            this.FFbtn.UseVisualStyleBackColor = true;
            // 
            // KMMbtn
            // 
            this.KMMbtn.AutoSize = true;
            this.KMMbtn.Location = new System.Drawing.Point(6, 47);
            this.KMMbtn.Name = "KMMbtn";
            this.KMMbtn.Size = new System.Drawing.Size(179, 19);
            this.KMMbtn.TabIndex = 1;
            this.KMMbtn.Text = "Ketchup, mustard, and mayo";
            this.KMMbtn.UseVisualStyleBackColor = true;
            // 
            // LTObtn
            // 
            this.LTObtn.AutoSize = true;
            this.LTObtn.Location = new System.Drawing.Point(6, 22);
            this.LTObtn.Name = "LTObtn";
            this.LTObtn.Size = new System.Drawing.Size(175, 19);
            this.LTObtn.TabIndex = 0;
            this.LTObtn.Text = "Lettuce, tomato, and onions";
            this.LTObtn.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(381, 162);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(104, 23);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(381, 201);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(381, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form";
            this.Text = "Lunch Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnSalad;
        private System.Windows.Forms.RadioButton btnPizza;
        private System.Windows.Forms.RadioButton rbtnHamburger;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox FFbtn;
        private System.Windows.Forms.CheckBox KMMbtn;
        private System.Windows.Forms.CheckBox LTObtn;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton btnHamburger;
    }
}

