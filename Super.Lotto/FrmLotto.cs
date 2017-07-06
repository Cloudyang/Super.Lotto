using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Super.Lotto
{
    public partial class FrmLotto : Form
    {
        private List<Ball> Balls = new List<Ball>();

        private bool IsStart = true;

        public FrmLotto()
        {
            InitializeComponent();
            InitBall();
        }

        /// <summary>
        /// 初始化球
        /// </summary>
        private void InitBall()
        {

            #region 前区球初始化
            for (int i = 0; i < 5; i++)
            {
                string lblProzoneName = $"lblProzone{i}";
                Label lblProzone = this.gboLotto.Controls[lblProzoneName] as Label;
                ProBall proball = new ProBall(lblProzoneName, i);
                proball.UpdateUI += proball_UpdateUI;
                lblProzone.Text = ProBall.Nums[i];
                Balls.Add(proball);
            }
            #endregion

            #region 后区球初始化
            for (int i = 0; i < 2; i++)
            {
                string lblPostzoneName = $"lblPostzone{i}";
                Label lblPostzone = this.gboLotto.Controls[lblPostzoneName] as Label;
                PostBall postball = new PostBall(lblPostzoneName, i);
                postball.UpdateUI += Postball_UpdateUI; ;
                lblPostzone.Text = PostBall.Nums[i];
                Balls.Add(postball);
            }
            #endregion
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.btnStart.Text = "开始ing";
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            this.IsStart = true;
            this.PickBall();
        }

        private async Task PickBall()
        {
            //第一种 异步实现方式（外面调用异步，内部同步）
          await  Task.Run(
                      () =>
                        {
                            while (IsStart)
                            {
                                Parallel.ForEach(Balls, ball =>
                                {
                                    ball.PickBall();
                                });
                                Task.Delay(500);
                            }
                        });
            MessageShow();
            //第二种 异步实现方式 (外面调用同步，内部异步）不明原因发生死锁 这种方式不可控
            //Task.Run(
            //          () =>
            //          {
            //              while (IsStart)
            //              {
            //                  foreach (var ball in Balls)
            //                  {
            //                      ball.PickBall();
            //                  }
            //                  Task.Delay(1500);
            //              }
            //          });
        }

        private void MessageShow()
        {
            var sb = new StringBuilder();
            foreach(Control lbl in this.gboLotto.Controls)
            {
                if(lbl is Label)
                {
                    sb.Append($"{lbl.Text} ");
                }
            }
            MessageBox.Show($"本期双色球结果是{sb.ToString()}");
        }

        private void Postball_UpdateUI(string controlName, int i)
        {
            base.Invoke(new Action(() =>
            {
                //   lock (PostBall._lock)
                {
                    this.gboLotto.Controls[controlName].Text = PostBall.Nums[i];
                }
            }));
        }

        private void proball_UpdateUI(string controlName, int i)
        {
            base.Invoke(new Action(() =>
            {
                //      lock (ProBall._lock)
                {
                    this.gboLotto.Controls[controlName].Text = ProBall.Nums[i];
                }
            }));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.btnStop.Enabled = false;
            this.btnStart.Enabled = true;
            btnStart.Text = "开始";
            this.IsStart = false;
        }
    }
}
