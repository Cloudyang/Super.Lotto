using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Model
{
    /// <summary>
    /// 前区球类
    /// </summary>
    public class ProBall : Ball
    {
        /// <summary>
        /// 声明彩球能出现的号码集
        /// </summary>
        public static string[] Nums = new string[] {
                "01","02","03","04","05","06","07","08","09","10",
            "11","12","13","14","15","16","17","18","19","20",
            "21","22","23","24","25","26","27","28","29","30",
            "31","32","33","34","35"
            };

        /// <summary>
        /// 锁信息
        /// </summary>
        public static readonly object _lock = new object();

        /// <summary>
        /// 初始化前区抽奖球号
        /// </summary>
        static ProBall()
        {
            Dict = new Dictionary<string, int>();
        }

        public ProBall(string lable, int index)
        {
            base.Lable = lable;
            base.Index = index;
            Dict.Add(lable, index);
        }

        /// <summary>
        /// 选号
        /// </summary>
        /// <returns></returns>
        public override void PickBall()
        {
            while (true)  //模拟递归没有相同保存，已有相同重新选号
            {
                lock (_lock)
                {
                    var index = RandomHelper.GetRandomNumber(Nums.Length);
                    if (!Dict.Values.Contains(index))
                    {
                        this.Index = index;
                        Dict[Lable] = index;
                        base.OnUpdateUI();
                        break;
                    }
                }
            }
        }
    }
}
