using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAW {
    public partial class frmMain : Form {

        private string CAW_IMAGE_FILE_PATH_ = Application.StartupPath + "\\cawimage2.jpg";
        const string CAW_INFO_MSG_ = "Do you want to start a CAW ?";

        /// *********************************************************************************************
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// *********************************************************************************************
        public frmMain() {
            InitializeComponent();

            //==================================================
            // 初期化
            //==================================================
            Initialize();
        }

        /// *********************************************************************************************
        /// <summary>
        /// 初期化
        /// </summary>
        /// *********************************************************************************************
        private void Initialize() {

            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 200;
            toolTip1.ReshowDelay = 500;

            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(lblCaw, "Post your message");
        }

        /// *********************************************************************************************
        /// <summary>
        /// メイン処理
        /// </summary>
        /// *********************************************************************************************
        private void main() {
            MessageBox.Show("Hello world");
        }

        /// *********************************************************************************************
        /// <summary>
        /// キーダウンイベント Shift + Alt + Pで終了
        /// </summary>
        /// *********************************************************************************************
        private void frmMain_KeyDown(object sender, KeyEventArgs e) {

            // Shift + Alt + "P"
            if (!(e.Alt && e.Shift && e.KeyCode.Equals(Keys.P))) {
                return;
            }

            Close();

        }

        /// *********************************************************************************************
        /// <summary>
        /// CAWボタンクリックイベント
        /// </summary>
        /// *********************************************************************************************
        private void btnCaw_Click(object sender, EventArgs e) {
            try {
                Close();

            } catch (Exception ex) {
                ShowMessage.ShowErrorMessage("System Error" + "\r" +
                                             "content：" + ex.Message + "\r" +
                                             "detail：" + ex.StackTrace);

            }
        }

        /// *********************************************************************************************
        /// <summary>
        /// CAWラベルクリックイベント
        /// </summary>
        /// *********************************************************************************************
        private void lblCaw_Click(object sender, EventArgs e) {
            //Label LabelObject = (Label)sender;
            try {
                if (ShowMessage.ShowYesNoMessage(CAW_INFO_MSG_)) {
                    //frmCAW CAW = new frmCAW();

                    //CAW.ShowDialog();
                    //CAW.Dispose();

                    BackgroundImage = Image.FromFile(CAW_IMAGE_FILE_PATH_);
                } else {
                    Close();
                }

            } catch (Exception ex) {
                ShowMessage.ShowErrorMessage("System Error" + "\r" +
                                             "content：" + ex.Message + "\r" +
                                             "detail：" + ex.StackTrace);

            }
        }
    }   //--end class

    /// <summary>
    /// message class
    /// </summary>
    class ShowMessage {

        ///*********************************************************************************************
        /// <summary>
        /// Yes / No message
        /// </summary>
        /// <param name="_Message">Display text</param>
        /// <param name="_Title">window title</param>
        /// <returns>
        /// Yes = true
        /// No = false        
        /// </returns>
        ///*********************************************************************************************
        public static bool ShowYesNoMessage(string _Message, string _Title = "CAW") {

            return MessageBox.Show(_Message, _Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information).Equals(DialogResult.Yes);

        }

        /// *********************************************************************************************
        /// <summary>
        /// Erroe message
        /// </summary>
        /// <param name="_Message">Display text</param>
        /// <param name="_Title">window title</param>
        /// <returns>dialogresult</returns>
        /// *********************************************************************************************
        public static DialogResult ShowErrorMessage(string _Message, string _Title = "CAW", bool IsTop = false) {
            if (IsTop) {
                return MessageBox.Show(_Message, _Title, MessageBoxButtons.OK, MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            } else {
                return MessageBox.Show(_Message, _Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }   //--end class

}   //--end namespace
