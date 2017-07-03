using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Ball
    {
        /// <summary>
        /// 同步记录所有彩球的下标号（已中奖号池）
        /// </summary>
        protected static Dictionary<string, int> Dict { get; set; }

        /// <summary>
        /// 彩球对应号
        /// </summary>
        public string Lable { get; set; }

        /// <summary>
        /// 彩球中奖号
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 声明UI处理事件
        /// </summary>
        public event Action<string, int> UpdateUI;

        /// <summary>
        /// 选号
        /// </summary>
        /// <returns></returns>
        public abstract void PickBall();

        /// <summary>
        /// 刷新前端显示
        /// </summary>
        protected void OnAction()
        {
            Dict[Lable] = Index;
            UpdateUI?.Invoke(this.Lable, this.Index);
        }
    }
}
