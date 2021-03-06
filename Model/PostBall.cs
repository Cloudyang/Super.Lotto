﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Model
{
    /// <summary>
    /// 后区球类
    /// </summary>
    public class PostBall : Ball
    {
        /// <summary>
        /// 声明彩球能出现的号码集
        /// </summary>
        public static string[] Nums = new string[] {
                "01","02","03","04","05","06","07","08","09","10", "11","12"
            };

        /// <summary>
        /// 锁信息
        /// </summary>
        private static readonly object _lock = new object();

        /// <summary>
        /// 初始化后区抽奖球号
        /// </summary>
        static PostBall()
        {
            Dict = new Dictionary<string, int>();
        }

        public PostBall(string lable, int index)
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
                var index = RandomHelper.GetRandomNumber(Nums.Length);
                if (!Dict.Values.Contains(index))
                {
                    lock (_lock)
                    {
                        if (!Dict.Values.Contains(index))
                        {
                            this.Index = index;
                            Dict[Lable] = index;
                            //     base.OnUpdateUI();
                            break;
                        }
                    }
                }
            }
            //界面同步显示效果差
            base.OnUpdateUI();
        }

        //第二种 内部异步有很多不可控
        //public override async void PickBall()
        //{
        //    await Task.Run(() =>
        //    {
        //        while (true)  //模拟递归没有相同保存，已有相同重新选号
        //        {
        //            var index = RandomHelper.GetRandomNumber(Nums.Length);
        //            if (!Dict.Values.Contains(index))
        //            {
        //                lock (_lock)
        //                {
        //                    if (!Dict.Values.Contains(index))
        //                    {
        //                        this.Index = index;
        //                        Dict[Lable] = index;
        //                        base.OnUpdateUI();
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    });
        //}
    }
}
