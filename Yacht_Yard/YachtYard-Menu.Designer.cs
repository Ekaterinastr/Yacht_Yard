
namespace Yacht_Yard
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
            this.lMenu = new System.Windows.Forms.Label();
            this.bUser = new System.Windows.Forms.Button();
            this.bProduct = new System.Windows.Forms.Button();
            this.bCost = new System.Windows.Forms.Button();
            this.bVixod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lMenu
            // 
            this.lMenu.AutoSize = true;
            this.lMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMenu.Location = new System.Drawing.Point(345, 75);
            this.lMenu.Name = "lMenu";
            this.lMenu.Size = new System.Drawing.Size(86, 29);
            this.lMenu.TabIndex = 0;
            this.lMenu.Text = "Меню ";
            // 
            // bUser
            // 
            this.bUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUser.Location = new System.Drawing.Point(41, 209);
            this.bUser.Name = "bUser";
            this.bUser.Size = new System.Drawing.Size(158, 48);
            this.bUser.TabIndex = 1;
            this.bUser.Text = "Пользователи";
            this.bUser.UseVisualStyleBackColor = true;
            this.bUser.Click += new System.EventHandler(this.bUser_Click);
            // 
            // bProduct
            // 
            this.bProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bProduct.Location = new System.Drawing.Point(228, 211);
            this.bProduct.Name = "bProduct";
            this.bProduct.Size = new System.Drawing.Size(297, 48);
            this.bProduct.TabIndex = 2;
            this.bProduct.Text = "Производство продукции";
            this.bProduct.UseVisualStyleBackColor = true;
            this.bProduct.Click += new System.EventHandler(this.bProduct_Click);
            // 
            // bCost
            // 
            this.bCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCost.Location = new System.Drawing.Point(546, 211);
            this.bCost.Name = "bCost";
            this.bCost.Size = new System.Drawing.Size(208, 48);
            this.bCost.TabIndex = 3;
            this.bCost.Text = "Управление ценами";
            this.bCost.UseVisualStyleBackColor = true;
            this.bCost.Click += new System.EventHandler(this.bCost_Click);
            // 
            // bVixod
            // 
            this.bVixod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bVixod.Location = new System.Drawing.Point(546, 361);
            this.bVixod.Name = "bVixod";
            this.bVixod.Size = new System.Drawing.Size(167, 41);
            this.bVixod.TabIndex = 4;
            this.bVixod.Text = "Закрыть приложение";
            this.bVixod.UseVisualStyleBackColor = true;
            this.bVixod.Click += new System.EventHandler(this.bVixod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bVixod);
            this.Controls.Add(this.bCost);
            this.Controls.Add(this.bProduct);
            this.Controls.Add(this.bUser);
            this.Controls.Add(this.lMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YachYard-Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMenu;
        private System.Windows.Forms.Button bUser;
        private System.Windows.Forms.Button bProduct;
        private System.Windows.Forms.Button bCost;
        private System.Windows.Forms.Button bVixod;
    }
}

