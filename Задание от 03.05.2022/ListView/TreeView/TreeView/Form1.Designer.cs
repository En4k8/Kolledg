
namespace TreeView
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Япония");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Китай");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Монголия");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Восточные", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Гермния");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Великобритания");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Италия");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Испания");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Франция");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Западные", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Посещенные страны", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode10});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(37, 54);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел8";
            treeNode1.Text = "Япония";
            treeNode2.Name = "Узел9";
            treeNode2.Text = "Китай";
            treeNode3.Name = "Узел10";
            treeNode3.Text = "Монголия";
            treeNode4.Name = "Узел1";
            treeNode4.Text = "Восточные";
            treeNode5.Name = "Узел7";
            treeNode5.Text = "Гермния";
            treeNode6.Name = "Узел6";
            treeNode6.Text = "Великобритания";
            treeNode7.Name = "Узел5";
            treeNode7.Text = "Италия";
            treeNode8.Name = "Узел4";
            treeNode8.Text = "Испания";
            treeNode9.Name = "Узел3";
            treeNode9.Text = "Франция";
            treeNode10.Name = "Узел2";
            treeNode10.Text = "Западные";
            treeNode11.Name = "Узел0";
            treeNode11.Text = "Посещенные страны";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(213, 227);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(311, 54);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(203, 227);
            this.treeView2.TabIndex = 1;
            // 
            // treeView3
            // 
            this.treeView3.Location = new System.Drawing.Point(587, 54);
            this.treeView3.Name = "treeView3";
            this.treeView3.Size = new System.Drawing.Size(207, 227);
            this.treeView3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(307, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавление через код:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(583, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Практическое задание:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

