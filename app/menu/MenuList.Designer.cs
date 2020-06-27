namespace DesktopAssistant.app.menu
{
    partial class MenuList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new DesktopAssistant.app.menu.MainMenu();
            this.mainMenu2 = new DesktopAssistant.app.menu.MainMenu();
            this.mainMenu3 = new DesktopAssistant.app.menu.MainMenu();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.BackColor = System.Drawing.Color.White;
            this.mainMenu1.Location = new System.Drawing.Point(0, 94);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(348, 48);
            this.mainMenu1.TabIndex = 0;
            // 
            // mainMenu2
            // 
            this.mainMenu2.BackColor = System.Drawing.Color.White;
            this.mainMenu2.Location = new System.Drawing.Point(0, 148);
            this.mainMenu2.Name = "mainMenu2";
            this.mainMenu2.Size = new System.Drawing.Size(348, 48);
            this.mainMenu2.TabIndex = 1;
            // 
            // mainMenu3
            // 
            this.mainMenu3.BackColor = System.Drawing.Color.White;
            this.mainMenu3.Location = new System.Drawing.Point(0, 202);
            this.mainMenu3.Name = "mainMenu3";
            this.mainMenu3.Size = new System.Drawing.Size(348, 48);
            this.mainMenu3.TabIndex = 2;
            // 
            // MenuList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainMenu3);
            this.Controls.Add(this.mainMenu2);
            this.Controls.Add(this.mainMenu1);
            this.Name = "MenuList";
            this.Size = new System.Drawing.Size(348, 288);
            this.ResumeLayout(false);

        }

        #endregion

        private MainMenu mainMenu1;
        private MainMenu mainMenu2;
        private MainMenu mainMenu3;
    }
}
